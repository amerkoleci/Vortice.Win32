// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text.RegularExpressions;
using System.Xml;
using MessagePack;
using Microsoft.Windows.SDK.Win32Docs;

namespace Generator;

public static class DocGenerator
{
    private static readonly Regex MDLink = new(@"\[([A-z0-9<>\\]+)\]\(([^\)]+)\)");
    private static readonly Regex ImgLink = new(@"!\[([A-z0-9<>\\]+)\]\(([^\)]+)\)");
    private static readonly Regex Bold = new(@"\*\*([^ ^\*][^\*^\n]*)\*\*");
    private static readonly Regex Italics = new(@"\*([^ ^\*][^\*^\n]*)\*");
    private static readonly Regex MultilineCode = new(@"```[A-z]*([^`]+)```");
    private static readonly Regex InlineCode = new(@"`([^`]+)`");
    private static readonly Regex Struct = new Regex(@"struct DML_[A-z0-9_]+_OPERATOR_DESC\r\n{[^}]+};", RegexOptions.Multiline);

    public static void Generate(string[] prefixes, string outputPath)
    {
        using FileStream docsStream = File.OpenRead(@"C:\Users\amerk\.nuget\packages\microsoft.windows.sdk.win32docs\0.1.8-alpha\apidocs.msgpack");
        var data = MessagePackSerializer.Deserialize<Dictionary<string, ApiDetails>>(docsStream);
        var documentationData = new Dictionary<string, ApiDetails>();

        foreach (string key in data.Keys)
        {
            //Debug.WriteLine(key);

            foreach (string prefix in prefixes)
            {
                if (key.StartsWith(prefix) || key.StartsWith("I" + prefix))
                {
                    if (prefix == "D3D")
                    {
                        if (key.StartsWith("D3D10") ||
                            key.StartsWith("D3D11") ||
                            key.StartsWith("D3DX11") ||
                            key.StartsWith("D3D12") ||
                            key.StartsWith("ID3D10") ||
                            key.StartsWith("ID3D11") ||
                            key.StartsWith("ID3D12") ||
                            key.StartsWith("ID3DX"))
                        {
                            continue;
                        }
                    }

                    documentationData.Add(key, data[key]);
                }
            }
        }

        XmlWriterSettings settings = new()
        {
            Indent = true,
        };
        //settings.ConformanceLevel = ConformanceLevel.Fragment;

        using (var writer = XmlWriter.Create(outputPath, settings))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement(null, "doc", null);

            foreach (var item in documentationData.Keys)
            {
                var doc = documentationData[item];

                if (!string.IsNullOrEmpty(doc.Description) || doc.Parameters.Count > 0)
                {
                    writer.WriteStartElement(null, "member", null);
                    writer.WriteAttributeString("name", item.Replace(".", "::"));
                    {
                        writer.WriteStartElement(null, "summary", null);
                        {
                            if (!string.IsNullOrEmpty(doc.Description))
                            {
                                writer.WriteStartElement(null, "para", null);
                                writer.WriteRaw(FormatMd(doc.Description));
                                writer.WriteEndElement(); // para
                            }

                            if (doc.HelpLink != null)
                            {
                                writer.WriteStartElement(null, "para", null);
                                writer.WriteString("Microsoft Docs: ");
                                writer.WriteStartElement(null, "see", null);
                                writer.WriteAttributeString("href", doc.HelpLink.ToString());
                                writer.WriteEndElement(); // see
                                writer.WriteEndElement(); // para
                            }

                            // Write params
                            foreach (var param in doc.Parameters)
                            {
                                if (!string.IsNullOrEmpty(param.Value))
                                {
                                    writer.WriteStartElement(null, "param", null);
                                    string paramName = param.Key;
                                    //if (paramName.StartsWith("pp") && char.IsUpper(paramName[2]))
                                    //{
                                    //    paramName = paramName.Substring(2);
                                    //    paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    //}
                                    //else if (paramName.StartsWith("p") && char.IsUpper(paramName[1]))
                                    //{
                                    //    paramName = paramName.Substring(1);
                                    //    paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    //}
                                    //else if (paramName.StartsWith("u") && char.IsUpper(paramName[1]))
                                    //{
                                    //    paramName = paramName.Substring(1);
                                    //    paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    //}
                                    //else if (paramName.StartsWith("b") && char.IsUpper(paramName[1])) // bEnable
                                    //{
                                    //    paramName = paramName.Substring(1);
                                    //    paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    //}
                                    //else if (char.IsUpper(paramName[0]) && paramName.Length > 1 && char.IsLower(paramName[1]))
                                    //{
                                    //    paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    //}
                                    //else if (paramName == "ID")
                                    //{
                                    //    paramName = "id";
                                    //}
                                    //else if (paramName == "dwCookie")
                                    //{
                                    //    paramName = "cookie";
                                    //}

                                    writer.WriteAttributeString("name", paramName);

                                    if (!param.Value.StartsWith("Type:"))
                                    {
                                        writer.WriteRaw(FormatMd(param.Value));
                                    }
                                    else
                                    {
                                        var lines = param.Value.Split('\n');
                                        writer.WriteRaw(FormatMd(string.Join("\r\n", lines.Skip(2))));
                                    }

                                    writer.WriteEndElement(); // param
                                }

                            }
                        }
                        writer.WriteEndElement(); // summary
                    }
                    writer.WriteEndElement(); // comment
                }

                // Write fields
                foreach (var fieldName in doc.Fields.Keys)
                {
                    var field = doc.Fields[fieldName];

                    if (string.IsNullOrEmpty(field))
                    {
                        continue;
                    }

                    if (!field.StartsWith("Type:"))
                    {
                        // Enum value
                        writer.WriteStartElement(null, "member", null);
                        writer.WriteAttributeString("name", $"{item.Replace(".", "::")}::{fieldName}");
                        {
                            writer.WriteStartElement(null, "summary", null);
                            {
                                var a = FormatMd(field);
                                writer.WriteRaw(FormatMd(field));
                            }
                            writer.WriteEndElement(); // summary
                        }
                        writer.WriteEndElement(); // comment
                    }
                    else
                    {
                        // Struct field
                        writer.WriteStartElement(null, "member", null);
                        writer.WriteAttributeString("name", $"{item.Replace(".", "::")}::{fieldName}");
                        {
                            writer.WriteStartElement(null, "summary", null);
                            {
                                var lines = field.Split('\n');
                                writer.WriteRaw(FormatMd(string.Join("\r\n", lines.Skip(2))));
                            }
                            writer.WriteEndElement(); // summary
                        }
                        writer.WriteEndElement(); // comment
                    }
                }
            }

            writer.WriteEndElement(); // comments
            writer.WriteEndDocument();
        }
    }

    private static string FormatMd(string value)
    {
        value = ImgLink.Replace(value, "");
        value = MDLink.Replace(value, "<a href=\"https://docs.microsoft.com$2\">$1</a>");
        value = Bold.Replace(value, "<b>$1</b>");
        value = Italics.Replace(value, "<i>$1</i>");
        value = MultilineCode.Replace(value, "<code>$1</code>");
        value = InlineCode.Replace(value, "<c>$1</c>");

        value = value.Replace("<code>s<code>", "<c>s</c>");
        value = value.Replace("ns-d3d12video-d3d12_video_process_luma_key\"\"", "\"ns-d3d12video-d3d12_video_process_luma_key\"");
        value = value.Replace("&L", "&amp;l");

        value = value.Replace("& ", "&amp; ");
        value = value.Replace(" > ", " &gt; ");
        value = value.Replace(" < ", " &lt; ");
        value = value.Replace(" >= ", " &gt;= ");
        value = value.Replace(" <= ", " &lt;= ");
        value = value.Replace("<-", "&lt;-");
        value = value.Replace("->", "-&gt;");
        value = value.Replace("\n>", "\n&gt;");
        value = value.Replace("&mdash;", "—");

        return value;
    }
}
