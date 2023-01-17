using System.ComponentModel.DataAnnotations;

namespace MyShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(256)]
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}