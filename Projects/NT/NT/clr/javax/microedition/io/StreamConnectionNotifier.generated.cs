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
    public partial interface StreamConnectionNotifier : global::javax.microedition.io.Connection {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljavax/microedition/io/StreamConnection;")]
        global::javax.microedition.io.StreamConnection acceptAndOpen();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class StreamConnectionNotifier_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.microedition.io.@__StreamConnectionNotifier.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.microedition.io.StreamConnectionNotifier), typeof(global::javax.microedition.io.StreamConnectionNotifier_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.microedition.io.StreamConnectionNotifier), typeof(global::javax.microedition.io.StreamConnectionNotifier_))]
    internal sealed partial class @__StreamConnectionNotifier : global::java.lang.Object, global::javax.microedition.io.StreamConnectionNotifier {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_close0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_acceptAndOpen1;
        
        private @__StreamConnectionNotifier(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.microedition.io.@__StreamConnectionNotifier.staticClass = @__class;
            global::javax.microedition.io.@__StreamConnectionNotifier.j4n_close0 = @__env.GetMethodID(global::javax.microedition.io.@__StreamConnectionNotifier.staticClass, "close", "()V");
            global::javax.microedition.io.@__StreamConnectionNotifier.j4n_acceptAndOpen1 = @__env.GetMethodID(global::javax.microedition.io.@__StreamConnectionNotifier.staticClass, "acceptAndOpen", "()Ljavax/microedition/io/StreamConnection;");
        }
        
        public void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::javax.microedition.io.@__StreamConnectionNotifier.j4n_close0);
            }
        }
        
        public global::javax.microedition.io.StreamConnection acceptAndOpen() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.StreamConnection>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.io.@__StreamConnectionNotifier.j4n_acceptAndOpen1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__StreamConnectionNotifier);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "close", "close0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "acceptAndOpen", "acceptAndOpen1", "()Ljavax/microedition/io/StreamConnection;"));
            return methods;
        }
        
        private static void close0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.microedition.io.StreamConnectionNotifier @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.StreamConnectionNotifier>(@__env, @__obj);
            ((global::javax.microedition.io.Connection)(@__real)).close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle acceptAndOpen1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljavax/microedition/io/StreamConnection;
            // ()Ljavax/microedition/io/StreamConnection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.microedition.io.StreamConnectionNotifier @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.microedition.io.StreamConnectionNotifier>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::javax.microedition.io.StreamConnection>(@__env, @__real.acceptAndOpen());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.microedition.io.@__StreamConnectionNotifier(@__env);
            }
        }
    }
    #endregion
}
