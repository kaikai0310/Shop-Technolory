namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public long ID { get; set; }

        [StringLength(250)]
        [Display(Name= "Category_Name",ResourceType =typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName ="Category_RequiredName",ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public string Name { get; set; }

        [StringLength(250)]
        [Required(ErrorMessageResourceName = "Category_RequiredMetaTitle", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        [Display(Name = "Category_MetaTitle", ResourceType = typeof(StaticResources.Resource))]
        public string MetaTitle { get; set; }

        [Display(Name = "Category_ParentID", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredParentID", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public long? ParentID { get; set; }

        [Display(Name = "Category_DisplayOrder", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredDisplayOrder", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public int? DisplayOrder { get; set; }

        [Display(Name = "Category_SeoTitle", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredSeoTitle", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        [StringLength(250)]
        public string SeoTitle { get; set; }

        
        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
       
        public string CreateBy { get; set; }

       
        public DateTime? ModifiedDate { get; set; }

       
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_MetaKeyword", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredMetaKeywords", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_MetaDescription", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredMetaDescription", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public string MetaDescription { get; set; }

        [Display(Name = "Category_Status", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredStatus", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public bool? Status { get; set; }

        [Display(Name = "Category_ShowOnHome", ResourceType = typeof(StaticResources.Resource))]
        [Required(ErrorMessageResourceName = "Category_RequiredShowOnHome", ErrorMessageResourceType = typeof(StaticResources.Resource))]
        public bool? ShowOnHome { get; set; }

        
        public string Language { get; set; }
    }
}
