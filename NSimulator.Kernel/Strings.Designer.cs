﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NSimulator.Kernel {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NSimulator.Kernel.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Часы уничтожены..
        /// </summary>
        internal static string ClockDestroyedException {
            get {
                return ResourceManager.GetString("ClockDestroyedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Среда передачи данных &quot;{0}&quot; не может содержать больше, чем {1} конечных точек..
        /// </summary>
        internal static string EndPointsOverflowException {
            get {
                return ResourceManager.GetString("EndPointsOverflowException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сущность &quot;{0}&quot; не найдена в топологии..
        /// </summary>
        internal static string EntityHandlerNotFoundException {
            get {
                return ResourceManager.GetString("EntityHandlerNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Устройство &quot;{0}&quot; не поддерживает возможность &quot;{1}&quot;..
        /// </summary>
        internal static string FeatureNotSupportedException {
            get {
                return ResourceManager.GetString("FeatureNotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс &quot;{0}&quot; уже привязан к другой среде передачи данных..
        /// </summary>
        internal static string InterfaceAlreadyAttachedToBackboneException {
            get {
                return ResourceManager.GetString("InterfaceAlreadyAttachedToBackboneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс &quot;{0}&quot; уже привязан к другому устройству..
        /// </summary>
        internal static string InterfaceAlreadyAttachedToDeviceException {
            get {
                return ResourceManager.GetString("InterfaceAlreadyAttachedToDeviceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс с именем &quot;{0}&quot; уже существует в устройстве &quot;{1}&quot;..
        /// </summary>
        internal static string InterfaceNameMustBeUniqueException {
            get {
                return ResourceManager.GetString("InterfaceNameMustBeUniqueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс с именем &quot;{0}&quot; не содержится ни в одной среде передачи данных..
        /// </summary>
        internal static string InterfaceNotAttachedToBackboneException1 {
            get {
                return ResourceManager.GetString("InterfaceNotAttachedToBackboneException1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс с именем &quot;{0}&quot; не содержится в среде передачи &quot;{1}&quot;..
        /// </summary>
        internal static string InterfaceNotAttachedToBackboneException2 {
            get {
                return ResourceManager.GetString("InterfaceNotAttachedToBackboneException2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс с именем &quot;{0}&quot; не содержится ни в одном устройстве..
        /// </summary>
        internal static string InterfaceNotAttachedToDeviceException1 {
            get {
                return ResourceManager.GetString("InterfaceNotAttachedToDeviceException1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс с именем &quot;{0}&quot; не содержится в устройстве &quot;{1}&quot;..
        /// </summary>
        internal static string InterfaceNotAttachedToDeviceException2 {
            get {
                return ResourceManager.GetString("InterfaceNotAttachedToDeviceException2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс &quot;{0}&quot; несовместим со средой передачи &quot;{1}&quot;..
        /// </summary>
        internal static string InterfaceNotCompatibleWithBackboneException {
            get {
                return ResourceManager.GetString("InterfaceNotCompatibleWithBackboneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейса с именем &quot;{0}&quot; не существует в устройстве &quot;{1}&quot;..
        /// </summary>
        internal static string InterfaceNotFoundException {
            get {
                return ResourceManager.GetString("InterfaceNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор действия в часах: &quot;{0}&quot;..
        /// </summary>
        internal static string InvalidClockHandlerException {
            get {
                return ResourceManager.GetString("InvalidClockHandlerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Класс с именем &quot;{0}&quot; не реализует интерфейс IInterfaceView..
        /// </summary>
        internal static string InvalidInterfaceClassException {
            get {
                return ResourceManager.GetString("InvalidInterfaceClassException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Класс с именем &quot;{0}&quot; не реализует интерфейс IModule..
        /// </summary>
        internal static string InvalidModuleClassException {
            get {
                return ResourceManager.GetString("InvalidModuleClassException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Параметр с именем &quot;{0}&quot; имеет неверное значение &quot;{1}&quot;.
        ///{2}.
        /// </summary>
        internal static string InvalidParameterException {
            get {
                return ResourceManager.GetString("InvalidParameterException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка добавления прошивки с идентификатором &quot;{0}&quot; в устройство с идентификатором &quot;{1}&quot;.
        ///{2}.
        /// </summary>
        internal static string LoadError_AddEngineFailed {
            get {
                return ResourceManager.GetString("LoadError_AddEngineFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка добавления интерфейса с идентификатором &quot;{0}&quot; в устройство с идентификатором &quot;{1}&quot;.
        ///{2}.
        /// </summary>
        internal static string LoadError_AddInterfaceFailed {
            get {
                return ResourceManager.GetString("LoadError_AddInterfaceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка загрузки сборки &quot;{0}&quot;.
        ///{1}.
        /// </summary>
        internal static string LoadError_AssemblyLoadFailed {
            get {
                return ResourceManager.GetString("LoadError_AssemblyLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка загрузки класса {0} из сборки &quot;{1}&quot;.
        ///{2}.
        /// </summary>
        internal static string LoadError_ClassLoadFailed {
            get {
                return ResourceManager.GetString("LoadError_ClassLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка загрузки сущности с идентификатором &quot;{0}&quot;.
        ///{1}.
        /// </summary>
        internal static string LoadError_EntityLoadFailed {
            get {
                return ResourceManager.GetString("LoadError_EntityLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка выполнения привязки интерфейса с идентификатором &quot;{0}&quot; к среде передачи с идентификатором &quot;{1}&quot;.
        ///{2}.
        /// </summary>
        internal static string LoadError_SetBackboneFailed {
            get {
                return ResourceManager.GetString("LoadError_SetBackboneFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Устройство с идентификатором &quot;{0}&quot; имеет две прошивки. Будет использоваться первая..
        /// </summary>
        internal static string LoadError_TwoEngines {
            get {
                return ResourceManager.GetString("LoadError_TwoEngines", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор среды передачи данных: &quot;{0}&quot;. Среда передачи будет проигнорирована..
        /// </summary>
        internal static string LoadError_WrongBackboneId {
            get {
                return ResourceManager.GetString("LoadError_WrongBackboneId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор класса сущности &quot;{0}&quot; : &quot;{1}&quot;..
        /// </summary>
        internal static string LoadError_WrongClassId {
            get {
                return ResourceManager.GetString("LoadError_WrongClassId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный тип сущности &quot;{0}&quot;. Ожидался объект типа &quot;{1}&quot;, но объект имеет тип &quot;{2}&quot;..
        /// </summary>
        internal static string LoadError_WrongClassType {
            get {
                return ResourceManager.GetString("LoadError_WrongClassType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор устройства: &quot;{0}&quot;. Устройство будет проигнорировано..
        /// </summary>
        internal static string LoadError_WrongDeviceId {
            get {
                return ResourceManager.GetString("LoadError_WrongDeviceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор прошивки: &quot;{0}&quot;. Прошивка будет проигнорирована..
        /// </summary>
        internal static string LoadError_WrongEngineId {
            get {
                return ResourceManager.GetString("LoadError_WrongEngineId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор интерфейса: &quot;{0}&quot;. Интерфейс будет проигнорирован..
        /// </summary>
        internal static string LoadError_WrongInterfaceId {
            get {
                return ResourceManager.GetString("LoadError_WrongInterfaceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неверный идентификатор модуля: &quot;{0}&quot;. Модуль будет проигнорирован..
        /// </summary>
        internal static string LoadError_WrongModuleId {
            get {
                return ResourceManager.GetString("LoadError_WrongModuleId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда с названием &quot;{0}&quot; не может быть добавлена одновременно в несколько контекстов..
        /// </summary>
        internal static string MenuCommandAlreadyHasContextException {
            get {
                return ResourceManager.GetString("MenuCommandAlreadyHasContextException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Название команды &quot;{0}&quot; не является уникальным в пределах контекста &quot;{1}&quot;..
        /// </summary>
        internal static string MenuCommandNameMustBeUniqueException {
            get {
                return ResourceManager.GetString("MenuCommandNameMustBeUniqueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Команда с названием &quot;{0}&quot; отсутствует в контексте &quot;{1}&quot;..
        /// </summary>
        internal static string MenuCommandNotFoundException {
            get {
                return ResourceManager.GetString("MenuCommandNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст с названием &quot;{0}&quot; не может быть добавлен одновременно в несколько контекстов..
        /// </summary>
        internal static string MenuContextAlreadyHasParentException {
            get {
                return ResourceManager.GetString("MenuContextAlreadyHasParentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Название контекста &quot;{0}&quot; не является уникальным в пределах контекста &quot;{1}&quot;..
        /// </summary>
        internal static string MenuContextNameMustBeUniqueException {
            get {
                return ResourceManager.GetString("MenuContextNameMustBeUniqueException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст с названием &quot;{0}&quot; отсутствует в контексте &quot;{1}&quot;..
        /// </summary>
        internal static string MenuContextNotFoundException {
            get {
                return ResourceManager.GetString("MenuContextNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Название элемента меню &quot;{0}&quot; неоднозначно дополняется в пределах контекста &quot;{1}&quot;..
        /// </summary>
        internal static string MenuElementNameIsAmbigiousException {
            get {
                return ResourceManager.GetString("MenuElementNameIsAmbigiousException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Модуль класса &quot;{0}&quot; уже загружен в прошивку..
        /// </summary>
        internal static string ModuleAlreadyLoadedException {
            get {
                return ResourceManager.GetString("ModuleAlreadyLoadedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Среда передачи данных &quot;{0}&quot; уже имеется в топологии сети..
        /// </summary>
        internal static string NetworkContainsBackboneException {
            get {
                return ResourceManager.GetString("NetworkContainsBackboneException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Устройство &quot;{0}&quot; уже имеется в топологии сети..
        /// </summary>
        internal static string NetworkContainsDeviceException {
            get {
                return ResourceManager.GetString("NetworkContainsDeviceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Интерфейс &quot;{0}&quot; уже имеется в топологии сети..
        /// </summary>
        internal static string NetworkContainsInterfaceException {
            get {
                return ResourceManager.GetString("NetworkContainsInterfaceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Контекст &quot;{0}&quot; ожидает {1} параметров, но передано {2}..
        /// </summary>
        internal static string NotEnoughParametersException {
            get {
                return ResourceManager.GetString("NotEnoughParametersException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Модуль класса &quot;{0}&quot; является модулем уровня 0 и имеет зависимость от модуля в направлении &quot;от интерфейса&quot;..
        /// </summary>
        internal static string RedundantDependsException {
            get {
                return ResourceManager.GetString("RedundantDependsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Модуль класса &quot;{0}&quot; не является модулем уровня 0, однако содержит информацию о типах интерфейсов..
        /// </summary>
        internal static string RedundantInterfaceTypeException {
            get {
                return ResourceManager.GetString("RedundantInterfaceTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ошибка валидации xml-файла:
        ///{0}.
        /// </summary>
        internal static string SchemaValidationException {
            get {
                return ResourceManager.GetString("SchemaValidationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;x:schema id=&quot;TopologySchema&quot; xmlns:x=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;x:complexType name=&quot;class_list&quot;&gt;
        ///    &lt;x:sequence&gt;
        ///      &lt;x:element name=&quot;class&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///        &lt;x:complexType&gt;
        ///          &lt;x:attribute name=&quot;name&quot; type=&quot;x:string&quot; use=&quot;required&quot; /&gt;
        ///          &lt;x:attribute name=&quot;assembly&quot; type=&quot;x:string&quot; use=&quot;required&quot; /&gt;
        ///          &lt;x:attribute name=&quot;id&quot; type=&quot;x:unsignedLong&quot; use=&quot;required&quot; /&gt;
        ///        &lt;/x:complexType&gt;
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TopologySchema {
            get {
                return ResourceManager.GetString("TopologySchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Класс модуля &quot;{0}&quot; не содержит информацию об уровне работы..
        /// </summary>
        internal static string UnknownModuleLevelException {
            get {
                return ResourceManager.GetString("UnknownModuleLevelException", resourceCulture);
            }
        }
    }
}
