//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.intel.bluetooth.obex {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class BlueCoveOBEX : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_obexResponseCodes0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setPacketSize1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getPacketSize2;
        
        protected BlueCoveOBEX(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass = @__class;
            global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_obexResponseCodes0 = @__env.GetStaticMethodID(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, "obexResponseCodes", "(I)Ljava/lang/String;");
            global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_setPacketSize1 = @__env.GetStaticMethodID(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, "setPacketSize", "(Ljavax/microedition/io/Connection;I)V");
            global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_getPacketSize2 = @__env.GetStaticMethodID(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, "getPacketSize", "(Ljavax/microedition/io/Connection;)I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String obexResponseCodes(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_obexResponseCodes0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljavax/microedition/io/Connection;I)V")]
        public static void setPacketSize(global::javax.microedition.io.Connection par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_setPacketSize1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::javax.microedition.io.Connection>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljavax/microedition/io/Connection;)I")]
        public static int getPacketSize(global::javax.microedition.io.Connection par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallStaticIntMethod(global::com.intel.bluetooth.obex.BlueCoveOBEX.staticClass, global::com.intel.bluetooth.obex.BlueCoveOBEX.j4n_getPacketSize2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::javax.microedition.io.Connection>(@__env, par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.intel.bluetooth.obex.BlueCoveOBEX(@__env);
            }
        }
    }
    #endregion
}
