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
    public partial interface DiscoveryListener {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I[Ljavax/bluetooth/ServiceRecord;)V")]
        void servicesDiscovered(int par0, global::javax.bluetooth.ServiceRecord[] par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)V")]
        void serviceSearchCompleted(int par0, int par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljavax/bluetooth/RemoteDevice;Ljavax/bluetooth/DeviceClass;)V")]
        void deviceDiscovered(global::javax.bluetooth.RemoteDevice par0, global::javax.bluetooth.DeviceClass par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        void inquiryCompleted(int par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class DiscoveryListener_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::javax.bluetooth.@__DiscoveryListener.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INQUIRY_COMPLETED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_COMPLETED4)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INQUIRY_TERMINATED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_TERMINATED5)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int INQUIRY_ERROR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_ERROR6)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SERVICE_SEARCH_COMPLETED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_COMPLETED7)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SERVICE_SEARCH_TERMINATED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_TERMINATED8)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SERVICE_SEARCH_ERROR {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_ERROR9)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SERVICE_SEARCH_NO_RECORDS {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_NO_RECORDS10)));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SERVICE_SEARCH_DEVICE_NOT_REACHABLE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return ((int)(@__env.GetStaticIntField(global::javax.bluetooth.@__DiscoveryListener.staticClass, global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_DEVICE_NOT_REACHABLE11)));
            }
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::javax.bluetooth.DiscoveryListener), typeof(global::javax.bluetooth.DiscoveryListener_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::javax.bluetooth.DiscoveryListener), typeof(global::javax.bluetooth.DiscoveryListener_))]
    internal sealed partial class @__DiscoveryListener : global::java.lang.Object, global::javax.bluetooth.DiscoveryListener {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_servicesDiscovered0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_serviceSearchCompleted1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_deviceDiscovered2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_inquiryCompleted3;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INQUIRY_COMPLETED4;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INQUIRY_TERMINATED5;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INQUIRY_ERROR6;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SERVICE_SEARCH_COMPLETED7;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SERVICE_SEARCH_TERMINATED8;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SERVICE_SEARCH_ERROR9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SERVICE_SEARCH_NO_RECORDS10;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_SERVICE_SEARCH_DEVICE_NOT_REACHABLE11;
        
        private @__DiscoveryListener(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::javax.bluetooth.@__DiscoveryListener.staticClass = @__class;
            global::javax.bluetooth.@__DiscoveryListener.j4n_servicesDiscovered0 = @__env.GetMethodID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "servicesDiscovered", "(I[Ljavax/bluetooth/ServiceRecord;)V");
            global::javax.bluetooth.@__DiscoveryListener.j4n_serviceSearchCompleted1 = @__env.GetMethodID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "serviceSearchCompleted", "(II)V");
            global::javax.bluetooth.@__DiscoveryListener.j4n_deviceDiscovered2 = @__env.GetMethodID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "deviceDiscovered", "(Ljavax/bluetooth/RemoteDevice;Ljavax/bluetooth/DeviceClass;)V");
            global::javax.bluetooth.@__DiscoveryListener.j4n_inquiryCompleted3 = @__env.GetMethodID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "inquiryCompleted", "(I)V");
            global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_COMPLETED4 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "INQUIRY_COMPLETED", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_TERMINATED5 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "INQUIRY_TERMINATED", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_INQUIRY_ERROR6 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "INQUIRY_ERROR", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_COMPLETED7 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "SERVICE_SEARCH_COMPLETED", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_TERMINATED8 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "SERVICE_SEARCH_TERMINATED", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_ERROR9 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "SERVICE_SEARCH_ERROR", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_NO_RECORDS10 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "SERVICE_SEARCH_NO_RECORDS", "I");
            global::javax.bluetooth.@__DiscoveryListener.j4n_SERVICE_SEARCH_DEVICE_NOT_REACHABLE11 = @__env.GetStaticFieldID(global::javax.bluetooth.@__DiscoveryListener.staticClass, "SERVICE_SEARCH_DEVICE_NOT_REACHABLE", "I");
        }
        
        public void servicesDiscovered(int par0, global::javax.bluetooth.ServiceRecord[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::javax.bluetooth.@__DiscoveryListener.j4n_servicesDiscovered0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<global::javax.bluetooth.ServiceRecord[], global::javax.bluetooth.ServiceRecord>(@__env, par1));
            }
        }
        
        public void serviceSearchCompleted(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::javax.bluetooth.@__DiscoveryListener.j4n_serviceSearchCompleted1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        public void deviceDiscovered(global::javax.bluetooth.RemoteDevice par0, global::javax.bluetooth.DeviceClass par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::javax.bluetooth.@__DiscoveryListener.j4n_deviceDiscovered2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        public void inquiryCompleted(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::javax.bluetooth.@__DiscoveryListener.j4n_inquiryCompleted3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__DiscoveryListener);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "servicesDiscovered", "servicesDiscovered0", "(I[Ljavax/bluetooth/ServiceRecord;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "serviceSearchCompleted", "serviceSearchCompleted1", "(II)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "deviceDiscovered", "deviceDiscovered2", "(Ljavax/bluetooth/RemoteDevice;Ljavax/bluetooth/DeviceClass;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "inquiryCompleted", "inquiryCompleted3", "(I)V"));
            return methods;
        }
        
        private static void servicesDiscovered0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (I[Ljavax/bluetooth/ServiceRecord;)V
            // (I[Ljavax/bluetooth/ServiceRecord;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.bluetooth.DiscoveryListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.DiscoveryListener>(@__env, @__obj);
            @__real.servicesDiscovered(par0, global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<global::javax.bluetooth.ServiceRecord[], global::javax.bluetooth.ServiceRecord>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void serviceSearchCompleted1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0, int par1) {
            // (II)V
            // (II)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.bluetooth.DiscoveryListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.DiscoveryListener>(@__env, @__obj);
            @__real.serviceSearchCompleted(par0, par1);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void deviceDiscovered2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljavax/bluetooth/RemoteDevice;Ljavax/bluetooth/DeviceClass;)V
            // (Ljavax/bluetooth/RemoteDevice;Ljavax/bluetooth/DeviceClass;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.bluetooth.DiscoveryListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.DiscoveryListener>(@__env, @__obj);
            @__real.deviceDiscovered(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::javax.bluetooth.RemoteDevice>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::javax.bluetooth.DeviceClass>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void inquiryCompleted3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::javax.bluetooth.DiscoveryListener @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::javax.bluetooth.DiscoveryListener>(@__env, @__obj);
            @__real.inquiryCompleted(par0);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::javax.bluetooth.@__DiscoveryListener(@__env);
            }
        }
    }
    #endregion
}
