﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStore.Web.ProductService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDto", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
    [System.SerializableAttribute()]
    public partial class ProductDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnlineStore.Web.ProductService.CategoryDto CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsNewField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> UnitPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OnlineStore.Web.ProductService.CategoryDto Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsNew {
            get {
                return this.IsNewField;
            }
            set {
                if ((this.IsNewField.Equals(value) != true)) {
                    this.IsNewField = value;
                    this.RaisePropertyChanged("IsNew");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryDto", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
    [System.SerializableAttribute()]
    public partial class CategoryDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
    [System.SerializableAttribute()]
    public partial class FaultData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string FullMessage {
            get {
                return this.FullMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FullMessageField, value) != true)) {
                    this.FullMessageField = value;
                    this.RaisePropertyChanged("FullMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductCategorizationDto", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
    [System.SerializableAttribute()]
    public partial class ProductCategorizationDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ProductIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ProductService.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CreateProducts", ReplyAction="urn:IProductService/CreateProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/CreateProductsFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto[] CreateProducts(OnlineStore.Web.ProductService.ProductDto[] productsDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CreateProducts", ReplyAction="urn:IProductService/CreateProductsResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> CreateProductsAsync(OnlineStore.Web.ProductService.ProductDto[] productsDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CreateCategories", ReplyAction="urn:IProductService/CreateCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/CreateCategoriesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.CategoryDto[] CreateCategories(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CreateCategories", ReplyAction="urn:IProductService/CreateCategoriesResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> CreateCategoriesAsync(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UpdateProducts", ReplyAction="urn:IProductService/UpdateProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/UpdateProductsFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto[] UpdateProducts(OnlineStore.Web.ProductService.ProductDto[] productsDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UpdateProducts", ReplyAction="urn:IProductService/UpdateProductsResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> UpdateProductsAsync(OnlineStore.Web.ProductService.ProductDto[] productsDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UpdateCategories", ReplyAction="urn:IProductService/UpdateCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/UpdateCategoriesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.CategoryDto[] UpdateCategories(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UpdateCategories", ReplyAction="urn:IProductService/UpdateCategoriesResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> UpdateCategoriesAsync(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/DeleteProducts", ReplyAction="urn:IProductService/DeleteProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/DeleteProductsFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        void DeleteProducts(string[] produList);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/DeleteProducts", ReplyAction="urn:IProductService/DeleteProductsResponse")]
        System.Threading.Tasks.Task DeleteProductsAsync(string[] produList);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/DeleteCategories", ReplyAction="urn:IProductService/DeleteCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/DeleteCategoriesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        void DeleteCategories(string[] categoryList);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/DeleteCategories", ReplyAction="urn:IProductService/DeleteCategoriesResponse")]
        System.Threading.Tasks.Task DeleteCategoriesAsync(string[] categoryList);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CategorizeProduct", ReplyAction="urn:IProductService/CategorizeProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/CategorizeProductFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductCategorizationDto CategorizeProduct(System.Guid productId, System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/CategorizeProduct", ReplyAction="urn:IProductService/CategorizeProductResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductCategorizationDto> CategorizeProductAsync(System.Guid productId, System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UncategorizeProduct", ReplyAction="urn:IProductService/UncategorizeProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/UncategorizeProductFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        void UncategorizeProduct(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/UncategorizeProduct", ReplyAction="urn:IProductService/UncategorizeProductResponse")]
        System.Threading.Tasks.Task UncategorizeProductAsync(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProducts", ReplyAction="urn:IProductService/GetProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetProductsFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProducts", ReplyAction="urn:IProductService/GetProductsResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProductsForCategory", ReplyAction="urn:IProductService/GetProductsForCategoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetProductsForCategoryFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto[] GetProductsForCategory(System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProductsForCategory", ReplyAction="urn:IProductService/GetProductsForCategoryResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetProductsForCategoryAsync(System.Guid categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetNewProducts", ReplyAction="urn:IProductService/GetNewProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetNewProductsFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto[] GetNewProducts(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetNewProducts", ReplyAction="urn:IProductService/GetNewProductsResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetNewProductsAsync(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetCategoryById", ReplyAction="urn:IProductService/GetCategoryByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetCategoryByIdFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.CategoryDto GetCategoryById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetCategoryById", ReplyAction="urn:IProductService/GetCategoryByIdResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto> GetCategoryByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetCategories", ReplyAction="urn:IProductService/GetCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetCategoriesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.CategoryDto[] GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetCategories", ReplyAction="urn:IProductService/GetCategoriesResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> GetCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProductById", ReplyAction="urn:IProductService/GetProductByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(OnlineStore.Web.ProductService.FaultData), Action="urn:IProductService/GetProductByIdFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/OnlineStore.ServiceContracts.ModelDTOs")]
        OnlineStore.Web.ProductService.ProductDto GetProductById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IProductService/GetProductById", ReplyAction="urn:IProductService/GetProductByIdResponse")]
        System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto> GetProductByIdAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : OnlineStore.Web.ProductService.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<OnlineStore.Web.ProductService.IProductService>, OnlineStore.Web.ProductService.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OnlineStore.Web.ProductService.ProductDto[] CreateProducts(OnlineStore.Web.ProductService.ProductDto[] productsDtos) {
            return base.Channel.CreateProducts(productsDtos);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> CreateProductsAsync(OnlineStore.Web.ProductService.ProductDto[] productsDtos) {
            return base.Channel.CreateProductsAsync(productsDtos);
        }
        
        public OnlineStore.Web.ProductService.CategoryDto[] CreateCategories(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos) {
            return base.Channel.CreateCategories(categoriDtos);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> CreateCategoriesAsync(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos) {
            return base.Channel.CreateCategoriesAsync(categoriDtos);
        }
        
        public OnlineStore.Web.ProductService.ProductDto[] UpdateProducts(OnlineStore.Web.ProductService.ProductDto[] productsDtos) {
            return base.Channel.UpdateProducts(productsDtos);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> UpdateProductsAsync(OnlineStore.Web.ProductService.ProductDto[] productsDtos) {
            return base.Channel.UpdateProductsAsync(productsDtos);
        }
        
        public OnlineStore.Web.ProductService.CategoryDto[] UpdateCategories(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos) {
            return base.Channel.UpdateCategories(categoriDtos);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> UpdateCategoriesAsync(OnlineStore.Web.ProductService.CategoryDto[] categoriDtos) {
            return base.Channel.UpdateCategoriesAsync(categoriDtos);
        }
        
        public void DeleteProducts(string[] produList) {
            base.Channel.DeleteProducts(produList);
        }
        
        public System.Threading.Tasks.Task DeleteProductsAsync(string[] produList) {
            return base.Channel.DeleteProductsAsync(produList);
        }
        
        public void DeleteCategories(string[] categoryList) {
            base.Channel.DeleteCategories(categoryList);
        }
        
        public System.Threading.Tasks.Task DeleteCategoriesAsync(string[] categoryList) {
            return base.Channel.DeleteCategoriesAsync(categoryList);
        }
        
        public OnlineStore.Web.ProductService.ProductCategorizationDto CategorizeProduct(System.Guid productId, System.Guid categoryId) {
            return base.Channel.CategorizeProduct(productId, categoryId);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductCategorizationDto> CategorizeProductAsync(System.Guid productId, System.Guid categoryId) {
            return base.Channel.CategorizeProductAsync(productId, categoryId);
        }
        
        public void UncategorizeProduct(System.Guid productId) {
            base.Channel.UncategorizeProduct(productId);
        }
        
        public System.Threading.Tasks.Task UncategorizeProductAsync(System.Guid productId) {
            return base.Channel.UncategorizeProductAsync(productId);
        }
        
        public OnlineStore.Web.ProductService.ProductDto[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public OnlineStore.Web.ProductService.ProductDto[] GetProductsForCategory(System.Guid categoryId) {
            return base.Channel.GetProductsForCategory(categoryId);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetProductsForCategoryAsync(System.Guid categoryId) {
            return base.Channel.GetProductsForCategoryAsync(categoryId);
        }
        
        public OnlineStore.Web.ProductService.ProductDto[] GetNewProducts(int count) {
            return base.Channel.GetNewProducts(count);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto[]> GetNewProductsAsync(int count) {
            return base.Channel.GetNewProductsAsync(count);
        }
        
        public OnlineStore.Web.ProductService.CategoryDto GetCategoryById(System.Guid id) {
            return base.Channel.GetCategoryById(id);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto> GetCategoryByIdAsync(System.Guid id) {
            return base.Channel.GetCategoryByIdAsync(id);
        }
        
        public OnlineStore.Web.ProductService.CategoryDto[] GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.CategoryDto[]> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
        
        public OnlineStore.Web.ProductService.ProductDto GetProductById(System.Guid id) {
            return base.Channel.GetProductById(id);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.Web.ProductService.ProductDto> GetProductByIdAsync(System.Guid id) {
            return base.Channel.GetProductByIdAsync(id);
        }
    }
}
