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
    public partial interface Operation : global::javax.microedition.io.ContentConnection {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getResponseCode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljavax/obex/HeaderSet;")]
        global::javax.obex.HeaderSet getReceivedHeaders();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void abort();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljavax/obex/HeaderSet;)V")]
        void sendHeaders(global::javax.obex.HeaderSet par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Operation_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.obex.@__Operation.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.obex.Operation), typeof(global::javax.obex.Operation_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.obex.Operation), typeof(global::javax.obex.Operation_))]
    internal sealed partial class @__Operation : global::java.lang.Object, global::javax.obex.Operation {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_close0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openDataInputStream1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openInputStream2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openDataOutputStream3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_openOutputStream4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getLength5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getType6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getEncoding7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getResponseCode8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getReceivedHeaders9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_abort10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_sendHeaders11;
        
        private @__Operation(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.obex.@__Operation.staticClass = @__class;
            global::javax.obex.@__Operation.j4n_close0 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "close", "()V");
            global::javax.obex.@__Operation.j4n_openDataInputStream1 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "openDataInputStream", "()Ljava/io/DataInputStream;");
            global::javax.obex.@__Operation.j4n_openInputStream2 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "openInputStream", "()Ljava/io/InputStream;");
            global::javax.obex.@__Operation.j4n_openDataOutputStream3 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "openDataOutputStream", "()Ljava/io/DataOutputStream;");
            global::javax.obex.@__Operation.j4n_openOutputStream4 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "openOutputStream", "()Ljava/io/OutputStream;");
            global::javax.obex.@__Operation.j4n_getLength5 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "getLength", "()J");
            global::javax.obex.@__Operation.j4n_getType6 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "getType", "()Ljava/lang/String;");
            global::javax.obex.@__Operation.j4n_getEncoding7 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "getEncoding", "()Ljava/lang/String;");
            global::javax.obex.@__Operation.j4n_getResponseCode8 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "getResponseCode", "()I");
            global::javax.obex.@__Operation.j4n_getReceivedHeaders9 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "getReceivedHeaders", "()Ljavax/obex/HeaderSet;");
            global::javax.obex.@__Operation.j4n_abort10 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "abort", "()V");
            global::javax.obex.@__Operation.j4n_sendHeaders11 = @__env.GetMethodID(global::javax.obex.@__Operation.staticClass, "sendHeaders", "(Ljavax/obex/HeaderSet;)V");
        }
        
        public void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::javax.obex.@__Operation.j4n_close0);
            }
        }
        
        public global::java.io.InputStream openDataInputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_openDataInputStream1));
            }
        }
        
        public global::java.io.InputStream openInputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_openInputStream2));
            }
        }
        
        public global::java.io.FilterOutputStream openDataOutputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.FilterOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_openDataOutputStream3));
            }
        }
        
        public global::java.io.OutputStream openOutputStream() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_openOutputStream4));
            }
        }
        
        public long getLength() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::javax.obex.@__Operation.j4n_getLength5)));
            }
        }
        
        public global::java.lang.String getType() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_getType6));
            }
        }
        
        public global::java.lang.String getEncoding() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_getEncoding7));
            }
        }
        
        public int getResponseCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::javax.obex.@__Operation.j4n_getResponseCode8)));
            }
        }
        
        public global::javax.obex.HeaderSet getReceivedHeaders() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.HeaderSet>(@__env, @__env.CallObjectMethodPtr(this, global::javax.obex.@__Operation.j4n_getReceivedHeaders9));
            }
        }
        
        public void abort() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::javax.obex.@__Operation.j4n_abort10);
            }
        }
        
        public void sendHeaders(global::javax.obex.HeaderSet par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::javax.obex.@__Operation.j4n_sendHeaders11, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::javax.obex.HeaderSet>(@__env, par0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Operation);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "close", "close0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openDataInputStream", "openDataInputStream1", "()Ljava/io/DataInputStream;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openInputStream", "openInputStream2", "()Ljava/io/InputStream;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openDataOutputStream", "openDataOutputStream3", "()Ljava/io/DataOutputStream;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "openOutputStream", "openOutputStream4", "()Ljava/io/OutputStream;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getLength", "getLength5", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getType", "getType6", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getEncoding", "getEncoding7", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getResponseCode", "getResponseCode8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReceivedHeaders", "getReceivedHeaders9", "()Ljavax/obex/HeaderSet;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "abort", "abort10", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "sendHeaders", "sendHeaders11", "(Ljavax/obex/HeaderSet;)V"));
            return methods;
        }
        
        private static void close0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            ((global::javax.microedition.io.Connection)(@__real)).close();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openDataInputStream1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/DataInputStream;
            // ()Ljava/io/InputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.InputConnection)(@__real)).openDataInputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openInputStream2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/InputStream;
            // ()Ljava/io/InputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.InputConnection)(@__real)).openInputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openDataOutputStream3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/DataOutputStream;
            // ()Ljava/io/FilterOutputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.OutputConnection)(@__real)).openDataOutputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle openOutputStream4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/io/OutputStream;
            // ()Ljava/io/OutputStream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.OutputConnection)(@__real)).openOutputStream());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static long getLength5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = ((long)(((global::javax.microedition.io.ContentConnection)(@__real)).getLength()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getType6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.ContentConnection)(@__real)).getType());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getEncoding7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::javax.microedition.io.ContentConnection)(@__real)).getEncoding());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getResponseCode8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = ((int)(@__real.getResponseCode()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getReceivedHeaders9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljavax/obex/HeaderSet;
            // ()Ljavax/obex/HeaderSet;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::javax.obex.HeaderSet>(@__env, @__real.getReceivedHeaders());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void abort10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__real.abort();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void sendHeaders11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljavax/obex/HeaderSet;)V
            // (Ljavax/obex/HeaderSet;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.obex.Operation @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.Operation>(@__env, @__obj);
            @__real.sendHeaders(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.obex.HeaderSet>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.obex.@__Operation(@__env);
            }
        }
    }
    #endregion
}
