//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace javax.obex {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Authenticator {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([B)[B")]
        byte[] onAuthenticationResponse(byte[] par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;ZZ)Ljavax/obex/PasswordAuthentication;")]
        global::javax.obex.PasswordAuthentication onAuthenticationChallenge(global::java.lang.String par0, bool par1, bool par2);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Authenticator_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.obex.@__Authenticator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.obex.Authenticator), typeof(global::javax.obex.Authenticator_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.obex.Authenticator), typeof(global::javax.obex.Authenticator_))]
    internal sealed partial class @__Authenticator : global::java.lang.Object, global::javax.obex.Authenticator {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onAuthenticationResponse0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_onAuthenticationChallenge1;
        
        private @__Authenticator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.obex.@__Authenticator.staticClass = @__class;
            global::javax.obex.@__Authenticator.j4n_onAuthenticationResponse0 = @__env.GetMethodID(global::javax.obex.@__Authenticator.staticClass, "onAuthenticationResponse", "([B)[B");
            global::javax.obex.@__Authenticator.j4n_onAuthenticationChallenge1 = @__env.GetMethodID(global::javax.obex.@__Authenticator.staticClass, "onAuthenticationChallenge", "(Ljava/lang/String;ZZ)Ljavax/obex/PasswordAuthentication;");
        }
        
        public byte[] onAuthenticationResponse(byte[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Authenticator.j4n_onAuthenticationResponse0, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par0)));
            }
        }
        
        public global::javax.obex.PasswordAuthentication onAuthenticationChallenge(global::java.lang.String par0, bool par1, bool par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::javax.obex.PasswordAuthentication>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Authenticator.j4n_onAuthenticationChallenge1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Authenticator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onAuthenticationResponse", "onAuthenticationResponse0", "([B)[B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "onAuthenticationChallenge", "onAuthenticationChallenge1", "(Ljava/lang/String;ZZ)Ljavax/obex/PasswordAuthentication;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle onAuthenticationResponse0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // ([B)[B
            // ([B)[B
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Authenticator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Authenticator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayPrimC2J(@__env, @__real.onAuthenticationResponse(global::net.sf.jni4net.utils.Convertor.ArrayPrimJ2Cbyte(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle onAuthenticationChallenge1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, bool par1, bool par2) {
            // (Ljava/lang/String;ZZ)Ljavax/obex/PasswordAuthentication;
            // (Ljava/lang/String;ZZ)Ljavax/obex/PasswordAuthentication;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Authenticator @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Authenticator>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.onAuthenticationChallenge(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), par1, par2));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.obex.@__Authenticator(@__env);
            }
        }
    }
    #endregion
}
