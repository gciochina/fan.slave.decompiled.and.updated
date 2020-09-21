using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace WindowsApplication3.My
{
	//[CompilerGenerated]
	//[DebuggerNonUserCode]
	//[EditorBrowsable(EditorBrowsableState.Never)]
	//internal sealed class InternalXmlHelper
	//{
	//    public static string AttributeValue(IEnumerable<XElement> source, XName name)
	//    {
	//        get
	//        {
	//            string str;
	//            IEnumerator<XElement> enumerator = null;
	//            using (enumerator)
	//            {
	//                enumerator = source.GetEnumerator();
	//                if (enumerator.MoveNext())
	//                {
	//                    str = (string)enumerator.Current.Attribute(name);
	//                    return str;
	//                }
	//            }
	//            str = null;
	//            return str;
	//        }
	//        set
	//        {
	//            IEnumerator<XElement> enumerator = null;
	//            try
	//            {
	//                enumerator = source.GetEnumerator();
	//                if (enumerator.MoveNext())
	//                {
	//                    enumerator.Current.SetAttributeValue(name, value);
	//                }
	//            }
	//            finally
	//            {
	//                if (enumerator != null)
	//                {
	//                    enumerator.Dispose();
	//                }
	//            }
	//        }
	//    }

	//    public static string AttributeValue(XElement source, XName name)
	//    {
	//        get
	//        {
	//            return (string)source.Attribute(name);
	//        }
	//        set
	//        {
	//            source.SetAttributeValue(name, value);
	//        }
	//    }

	//    public static string Value(IEnumerable<XElement> source)
	//    {
	//        get
	//        {
	//            string value;
	//            IEnumerator<XElement> enumerator = null;
	//            using (enumerator)
	//            {
	//                enumerator = source.GetEnumerator();
	//                if (enumerator.MoveNext())
	//                {
	//                    value = enumerator.Current.Value;
	//                    return value;
	//                }
	//            }
	//            value = null;
	//            return value;
	//        }
	//        set
	//        {
	//            IEnumerator<XElement> enumerator = null;
	//            try
	//            {
	//                enumerator = source.GetEnumerator();
	//                if (enumerator.MoveNext())
	//                {
	//                    enumerator.Current.Value = value;
	//                }
	//            }
	//            finally
	//            {
	//                if (enumerator != null)
	//                {
	//                    enumerator.Dispose();
	//                }
	//            }
	//        }
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    private InternalXmlHelper()
	//    {
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    public static XAttribute CreateAttribute(XName name, object value)
	//    {
	//        XAttribute xAttribute;
	//        if (value != null)
	//        {
	//            xAttribute = new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
	//        }
	//        else
	//        {
	//            xAttribute = null;
	//        }
	//        return xAttribute;
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
	//    {
	//        XAttribute xAttribute = new XAttribute(name, ns.NamespaceName);
	//        xAttribute.AddAnnotation(ns);
	//        return xAttribute;
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
	//    {
	//        object obj1;
	//        if (obj != null)
	//        {
	//            XElement xElement = obj as XElement;
	//            if (xElement == null)
	//            {
	//                IEnumerable enumerable = obj as IEnumerable;
	//                if (enumerable != null)
	//                {
	//                    obj1 = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
	//                    return obj1;
	//                }
	//            }
	//            else
	//            {
	//                obj1 = InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xElement);
	//                return obj1;
	//            }
	//        }
	//        obj1 = obj;
	//        return obj1;
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
	//    {
	//        IEnumerable enumerable;
	//        if (obj == null)
	//        {
	//            enumerable = obj;
	//        }
	//        else
	//        {
	//            IEnumerable<XElement> xElements = obj as IEnumerable<XElement>;
	//            if (xElements == null)
	//            {
	//                enumerable = obj.Cast<object>().Select<object, object>((object argument0) =>
	//                {
	//                    XElement xElement = argument0 as XElement;
	//                    return (xElement == null ? argument0 : InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, xElement));
	//                });
	//            }
	//            else
	//            {
	//                enumerable =
	//                    from elem in xElements
	//                    select InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
	//            }
	//        }
	//        return enumerable;
	//    }

	//    [EditorBrowsable(EditorBrowsableState.Never)]
	//    public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
	//    {
	//        XAttribute nextAttribute = null;
	//        if (e != null)
	//        {
	//            for (XAttribute i = e.FirstAttribute; i != null; i = nextAttribute)
	//            {
	//                nextAttribute = i.NextAttribute;
	//                if (i.IsNamespaceDeclaration)
	//                {
	//                    XNamespace xNamespace = i.Annotation<XNamespace>();
	//                    string localName = i.Name.LocalName;
	//                    if (xNamespace != null)
	//                    {
	//                        if ((inScopePrefixes == null || inScopeNs == null ? false : true))
	//                        {
	//                            int length = checked(checked((int)inScopePrefixes.Length) - 1);
	//                            int num = 0;
	//                            while (num <= length)
	//                            {
	//                                string str = inScopePrefixes[num];
	//                                XNamespace xNamespace1 = inScopeNs[num];
	//                                if (!localName.Equals(str))
	//                                {
	//                                    num++;
	//                                }
	//                                else
	//                                {
	//                                    if (xNamespace == xNamespace1)
	//                                    {
	//                                        i.Remove();
	//                                    }
	//                                    i = null;
	//                                    break;
	//                                }
	//                            }
	//                        }
	//                        if (i != null)
	//                        {
	//                            if (attributes != null)
	//                            {
	//                                int count = checked(attributes.Count - 1);
	//                                for (int j = 0; j <= count; j++)
	//                                {
	//                                    XAttribute item = attributes[j];
	//                                    string localName1 = item.Name.LocalName;
	//                                    XNamespace xNamespace2 = item.Annotation<XNamespace>();
	//                                    if (xNamespace2 != null)
	//                                    {
	//                                        if (localName.Equals(localName1))
	//                                        {
	//                                            if (xNamespace == xNamespace2)
	//                                            {
	//                                                i.Remove();
	//                                            }
	//                                            i = null;
	//                                            break;
	//                                        }
	//                                    }
	//                                }
	//                            }
	//                            if (i != null)
	//                            {
	//                                i.Remove();
	//                                attributes.Add(i);
	//                            }
	//                        }
	//                    }
	//                }
	//            }
	//        }
	//        return e;
	//    }
	//}
}