﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.34209
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewRes {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Login {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Login() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KidsGEPT.Areas.backend.App_LocalResources.Main.Login", typeof(Login).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查詢類似 Welcome to KidsGEPT 的當地語系化字串。
        /// </summary>
        public static string Logindescription {
            get {
                return ResourceManager.GetString("Logindescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 請輸入E-mail 的當地語系化字串。
        /// </summary>
        public static string Loginemailvalidate {
            get {
                return ResourceManager.GetString("Loginemailvalidate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 您輸入的帳號或密碼錯誤 的當地語系化字串。
        /// </summary>
        public static string Loginerrormessage {
            get {
                return ResourceManager.GetString("Loginerrormessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 密碼 的當地語系化字串。
        /// </summary>
        public static string Loginformpassword {
            get {
                return ResourceManager.GetString("Loginformpassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 身分證字號 的當地語系化字串。
        /// </summary>
        public static string LoginformPID {
            get {
                return ResourceManager.GetString("LoginformPID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 登入 的當地語系化字串。
        /// </summary>
        public static string Loginformsignin {
            get {
                return ResourceManager.GetString("Loginformsignin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 登入 的當地語系化字串。
        /// </summary>
        public static string Loginformtitle {
            get {
                return ResourceManager.GetString("Loginformtitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 請輸入密碼 的當地語系化字串。
        /// </summary>
        public static string Loginpasswordvalidate {
            get {
                return ResourceManager.GetString("Loginpasswordvalidate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 小學GEPT後台管理 的當地語系化字串。
        /// </summary>
        public static string Logintitle {
            get {
                return ResourceManager.GetString("Logintitle", resourceCulture);
            }
        }
    }
}
