//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace javax.bluetooth {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface L2CAPConnectionNotifier : global::javax.microedition.io.Connection {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljavax/bluetooth/L2CAPConnection;")]
        global::javax.bluetooth.L2CAPConnection acceptAndOpen();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class L2CAPConnectionNotifier_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.bluetooth.@__L2CAPConnectionNotifier.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.bluetooth.L2CAPConnectionNotifier), typeof(global::javax.bluetooth.L2CAPConnectionNotifier_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.bluetooth.L2CAPConnectionNotifier), typeof(global::javax.bluetooth.L2CAPConnectionNotifier_))]
    internal sealed partial class @__L2CAPConnectionNotifier : global::java.lang.Object, global::javax.bluetooth.L2CAPConnectionNotifier {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_close0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_acceptAndOpen1;
        
        private @__L2CAPConnectionNotifier(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.bluetooth.@__L2CAPConnectionNotifier.staticClass = @__class;
            global::javax.bluetooth.@__L2CAPConnectionNotifier.j4n_close0 = @__env.GetMethodID(global::javax.bluetooth.@__L2CAPConnectionNotifier.staticClass, "close", "()V");
            global::javax.bluetooth.@__L2CAPConnectionNotifier.j4n_acceptAndOpen1 = @__env.GetMethodID(global::javax.bluetooth.@__L2CAPConnectionNotifier.staticClass, "acceptAndOpen", "()Ljavax/bluetooth/L2CAPConnection;");
        }
        
        public void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::javax.bluetooth.@__L2CAPConnectionNotifier.j4n_close0);
            }
        }
        
        public global::javax.bluetooth.L2CAPConnection acceptAndOpen() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.L2CAPConnection>(@__env, @__env.CallObjectMethodPtr(this, global::javax.bluetooth.@__L2CAPConnectionNotifier.j4n_acceptAndOpen1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__L2CAPConnectionNotifier);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "close", "close0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "acceptAndOpen", "acceptAndOpen1", "()Ljavax/bluetooth/L2CAPConnection;"));
            return methods;
        }
        
        private static void close0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.bluetooth.L2CAPConnectionNotifier @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.L2CAPConnectionNotifier>(@__env, @__obj);
            ((global::javax.microedition.io.Connection)(@__real)).close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle acceptAndOpen1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljavax/bluetooth/L2CAPConnection;
            // ()Ljavax/bluetooth/L2CAPConnection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.bluetooth.L2CAPConnectionNotifier @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.L2CAPConnectionNotifier>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::javax.bluetooth.L2CAPConnection>(@__env, @__real.acceptAndOpen());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.bluetooth.@__L2CAPConnectionNotifier(@__env);
            }
        }
    }
    #endregion
}
