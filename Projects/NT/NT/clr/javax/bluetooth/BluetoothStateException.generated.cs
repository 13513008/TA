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
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    [global::System.SerializableAttribute()]
    public partial class BluetoothStateException : global::java.lang.Exception {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorBluetoothStateException0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorBluetoothStateException1;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public BluetoothStateException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::javax.bluetooth.BluetoothStateException.staticClass, global::javax.bluetooth.BluetoothStateException.j4n__ctorBluetoothStateException0, this);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public BluetoothStateException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::javax.bluetooth.BluetoothStateException.staticClass, global::javax.bluetooth.BluetoothStateException.j4n__ctorBluetoothStateException1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        protected BluetoothStateException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        protected BluetoothStateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.bluetooth.BluetoothStateException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.bluetooth.BluetoothStateException.staticClass = @__class;
            global::javax.bluetooth.BluetoothStateException.j4n__ctorBluetoothStateException0 = @__env.GetMethodID(global::javax.bluetooth.BluetoothStateException.staticClass, "<init>", "()V");
            global::javax.bluetooth.BluetoothStateException.j4n__ctorBluetoothStateException1 = @__env.GetMethodID(global::javax.bluetooth.BluetoothStateException.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.bluetooth.BluetoothStateException(@__env);
            }
        }
    }
    #endregion
}
