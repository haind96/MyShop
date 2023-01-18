using System;

namespace MyShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}