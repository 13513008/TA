//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.intel.bluetooth {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class DebugLog : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_error11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_error12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_error13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_error14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug0x15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debug0x16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_fatal17;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_fatal18;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_nativeDebugCallback19;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_debugNative20;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_addAppender21;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isDebugEnabled22;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setDebugEnabled23;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_removeAppender24;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_DEBUG25;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_ERROR26;
        
        protected DebugLog(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.intel.bluetooth.DebugLog.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DEBUG {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_DEBUG25)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int ERROR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_ERROR26)));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.intel.bluetooth.DebugLog.staticClass = @__class;
            global::com.intel.bluetooth.DebugLog.j4n_debug0 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;Z)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug1 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;J)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug2 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug3 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;[BII)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug4 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;[I)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug5 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;[III)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug6 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug7 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug8 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug9 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;[B)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug10 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug", "(Ljava/lang/String;Ljava/lang/Object;)V");
            global::com.intel.bluetooth.DebugLog.j4n_error11 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "error", "(Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_error12 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "error", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_error13 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "error", "(Ljava/lang/String;J)V");
            global::com.intel.bluetooth.DebugLog.j4n_error14 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug0x15 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug0x", "(Ljava/lang/String;J)V");
            global::com.intel.bluetooth.DebugLog.j4n_debug0x16 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debug0x", "(Ljava/lang/String;Ljava/lang/String;J)V");
            global::com.intel.bluetooth.DebugLog.j4n_fatal17 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "fatal", "(Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_fatal18 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "fatal", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::com.intel.bluetooth.DebugLog.j4n_nativeDebugCallback19 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "nativeDebugCallback", "(Ljava/lang/String;ILjava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_debugNative20 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "debugNative", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::com.intel.bluetooth.DebugLog.j4n_addAppender21 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "addAppender", "(Lcom/intel/bluetooth/DebugLog$LoggerAppender;)V");
            global::com.intel.bluetooth.DebugLog.j4n_isDebugEnabled22 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "isDebugEnabled", "()Z");
            global::com.intel.bluetooth.DebugLog.j4n_setDebugEnabled23 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "setDebugEnabled", "(Z)V");
            global::com.intel.bluetooth.DebugLog.j4n_removeAppender24 = @__env.GetStaticMethodID(global::com.intel.bluetooth.DebugLog.staticClass, "removeAppender", "(Lcom/intel/bluetooth/DebugLog$LoggerAppender;)V");
            global::com.intel.bluetooth.DebugLog.j4n_DEBUG25 = @__env.GetStaticFieldID(global::com.intel.bluetooth.DebugLog.staticClass, "DEBUG", "I");
            global::com.intel.bluetooth.DebugLog.j4n_ERROR26 = @__env.GetStaticFieldID(global::com.intel.bluetooth.DebugLog.staticClass, "ERROR", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Z)V")]
        public static void debug(global::java.lang.String par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;J)V")]
        public static void debug(global::java.lang.String par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V")]
        public static void debug(global::java.lang.String par0, global::java.lang.String par1, global::java.lang.String par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[BII)V")]
        public static void debug(global::java.lang.String par0, byte[] par1, int par2, int par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[I)V")]
        public static void debug(global::java.lang.String par0, int[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[III)V")]
        public static void debug(global::java.lang.String par0, int[] par1, int par2, int par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public static void debug(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public static void debug(global::java.lang.String par0, global::java.lang.Throwable par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void debug(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[B)V")]
        public static void debug(global::java.lang.String par0, byte[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Object;)V")]
        public static void debug(global::java.lang.String par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void error(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_error11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public static void error(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_error12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;J)V")]
        public static void error(global::java.lang.String par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_error13, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public static void error(global::java.lang.String par0, global::java.lang.Throwable par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_error14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;J)V")]
        public static void debug0x(global::java.lang.String par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug0x15, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;J)V")]
        public static void debug0x(global::java.lang.String par0, global::java.lang.String par1, long par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debug0x16, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public static void fatal(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_fatal17, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public static void fatal(global::java.lang.String par0, global::java.lang.Throwable par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_fatal18, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;ILjava/lang/String;)V")]
        public static void nativeDebugCallback(global::java.lang.String par0, int par1, global::java.lang.String par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_nativeDebugCallback19, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public static void debugNative(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_debugNative20, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/intel/bluetooth/DebugLog$LoggerAppender;)V")]
        public static void addAppender(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_addAppender21, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public static bool isDebugEnabled() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_isDebugEnabled22)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public static void setDebugEnabled(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_setDebugEnabled23, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/intel/bluetooth/DebugLog$LoggerAppender;)V")]
        public static void removeAppender(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::com.intel.bluetooth.DebugLog.staticClass, global::com.intel.bluetooth.DebugLog.j4n_removeAppender24, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.intel.bluetooth.DebugLog(@__env);
            }
        }
    }
    #endregion
}
