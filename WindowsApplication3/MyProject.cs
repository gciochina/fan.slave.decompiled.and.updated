using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsApplication3;

namespace WindowsApplication3.My
{
    [GeneratedCode("MyTemplate", "10.0.0.0")]
    [HideModuleName]
    [StandardModule]
    internal sealed class MyProject
    {
        private readonly static MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

        private readonly static MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

        private readonly static MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider;

        private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider;

        private readonly static MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider;

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Forms")]
        internal static MyProject.MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyFormsObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyProject.MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return MyProject.m_MyWebServicesObjectProvider.GetInstance;
            }
        }

        [DebuggerNonUserCode]
        static MyProject()
        {
            MyProject.m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
            MyProject.m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
            MyProject.m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
            MyProject.m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
            MyProject.m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            public Form1 m_Form1;

            public Form2 m_Form2;

            public Form3 m_Form3;

            public Form4 m_Form4;

            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            public Form1 Form1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_Form1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Form1>(ref this.m_Form1);
                    }
                }
            }

            public Form2 Form2
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
                    return this.m_Form2;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_Form2)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Form2>(ref this.m_Form2);
                    }
                }
            }

            public Form3 Form3
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form3 = MyProject.MyForms.Create__Instance__<Form3>(this.m_Form3);
                    return this.m_Form3;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_Form3)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Form3>(ref this.m_Form3);
                    }
                }
            }

            public Form4 Form4
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form4 = MyProject.MyForms.Create__Instance__<Form4>(this.m_Form4);
                    return this.m_Form4;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_Form4)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Form4>(ref this.m_Form4);
                    }
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyForms()
            {
            }

//            [DebuggerHidden]
//            private static T Create__Instance__<T>(T Instance)
//            where T : Form, new()
//            {
//                T instance;
//                TargetInvocationException targetInvocationException = null;
//                if ((Instance == null || Instance.IsDisposed ? false : true))
//                {
//                    instance = Instance;
//                }
//                else
//                {
//                    if (MyProject.MyForms.m_FormBeingCreated == null)
//                    {
//                        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
//                    }
//                    else if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
//                    {
//                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
//                    }
//                    MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
//                    try
//                    {
//                        try
//                        {
//                            instance = Activator.CreateInstance<T>();
//                        }
//                        catch
//Current member / type: T WindowsApplication3.My.MyProject/MyForms::Create__Instance__(T)
//File path: D:\test\FS\Fanslave bot by Subcode.exe

//Product version: 2013.2.820.1
//Exception in: T Create__Instance__(T)

//Object reference not set to an instance of an object.
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\CSharp\CSharpWriter.cs:line 991
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 129
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..Visit(IEnumerable ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2068
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 3475
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 132
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..Visit(IEnumerable ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2068
//at ...() in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2030
//at ..(Action , String ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\CSharp\CSharpWriter.cs:line 409
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2028
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 81
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 3470
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 132
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..Visit(IEnumerable ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2068
//at ...() in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2030
//at ..(Action , String ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\CSharp\CSharpWriter.cs:line 409
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2028
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 81
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 3340
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 90
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..Visit(IEnumerable ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2068
//at ...() in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2030
//at ..(Action , String ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\CSharp\CSharpWriter.cs:line 409
//at ..( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2028
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:line 81
//at ..Visit( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1078
//at ..Write( ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1053
//at ..(MethodDefinition ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1807
//at ..Write(MethodDefinition ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1732
//at ..WriteInternal(IMemberDefinition , Boolean , Boolean ) in c:\Builds\245\Behemoth\JustDecompile Production Build\Sources\Decompiler\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 304

//mailto: JustDecompilePublicFeedback@telerik.com

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                T local;
                if ((((Instance == null) || Instance.IsDisposed) ? 1 : 0) == 0)
                {
                    return Instance;
                }
                if (m_FormBeingCreated != null)
                {
                    if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                }
                else
                {
                    m_FormBeingCreated = new Hashtable();
                }
                m_FormBeingCreated.Add(typeof(T), null);
                try
                {
                    return Activator.CreateInstance<T>();
                }
                catch (Exception ex)
                {
					TargetInvocationException exception = ex as TargetInvocationException;
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { exception.InnerException.Message }), exception.InnerException);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    m_FormBeingCreated.Remove(typeof(T));
                }
                return local;
            }


	        [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            where T : Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return this.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return this.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyProject.MyForms);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return this.ToString();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyWebServices()
            {
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance)
            where T : new()
            {
                T t;
                t = (instance != null ? instance : Activator.CreateInstance<T>());
                return t;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return this.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return this.GetHashCode();
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return this.ToString();
            }
        }

        [ComVisible(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class ThreadSafeObjectProvider<T>
        where T : new()
        {
			[ThreadStatic, CompilerGenerated]
			private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
            }
        }
    }
}