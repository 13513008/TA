//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace javax.microedition.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface OutputConnection : global::javax.microedition.io.Connection {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/DataOutputStream;")]
        global::java.io.FilterOutputStream openDataOutputStream();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/OutputStream;")]
        global::java.io.OutputStream openOutputStream();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class OutputConnection_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.microedition.io.@__OutputConnection.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.microedition.io.OutputConnection), typeof(global::javax.microedition.io.OutputConnection_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.microedition.io.OutputConnection), typeof(global::javax.microedition.io.OutputConnection_))]
    internal sealed partial class @__OutputConnection : global::java.lang.Object, global::javax.microedition.io.OutputConnection {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_close0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openDataOutputStream1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openOutputStream2;
        
        private @__OutputConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.microedition.io.@__OutputConnection.staticClass = @__class;
            global::javax.microedition.io.@__OutputConnection.j4n_close0 = @__env.GetMethodID(global::javax.microedition.io.@__OutputConnection.staticClass, "close", "()V");
            global::javax.microedition.io.@__OutputConnection.j4n_openDataOutputStream1 = @__env.GetMethodID(global::javax.microedition.io.@__OutputConnection.staticClass, "openDataOutputStream", "()Ljava/io/DataOutputStream;");
            global::javax.microedition.io.@__OutputConnection.j4n_openOutputStream2 = @__env.GetMethodID(global::javax.microedition.io.@__OutputConnection.staticClass, "openOutputStream", "()Ljava/io/OutputStream;");
        }
        
        public void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::javax.microedition.io.@__OutputConnection.j4n_close0);
            }
        }
        
        public global::java.io.FilterOutputStream openDataOutputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.FilterOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.io.@__OutputConnection.j4n_openDataOutputStream1));
            }
        }
        
        public global::java.io.OutputStream openOutputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.io.@__OutputConnection.j4n_openOutputStream2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__OutputConnection);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "close", "close0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openDataOutputStream", "openDataOutputStream1", "()Ljava/io/DataOutputStream;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openOutputStream", "openOutputStream2", "()Ljava/io/OutputStream;"));
            return methods;
        }
        
        private static void close0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.microedition.io.OutputConnection @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.OutputConnection>(@__env, @__obj);
            ((global::javax.microedition.io.Connection)(@__real)).close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openDataOutputStream1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/DataOutputStream;
            // ()Ljava/io/FilterOutputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.microedition.io.OutputConnection @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.OutputConnection>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.openDataOutputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openOutputStream2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/OutputStream;
            // ()Ljava/io/OutputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.microedition.io.OutputConnection @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.OutputConnection>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.openOutputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.microedition.io.@__OutputConnection(@__env);
            }
        }
    }
    #endregion
}
