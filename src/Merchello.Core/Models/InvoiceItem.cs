﻿using System;
using System.Runtime.Serialization;
using Merchello.Core.Models.EntityBase;
using Merchello.Core.Models.TypeFields;

namespace Merchello.Core.Models
{
    [DataContract]
    public class InvoiceItem : IdEntity, IInvoiceItem
    {

        private int? _parentId;
        private int _invoiceId;
        private int _shipmentId;
        private readonly IInvoiceItemItemization _itemization;
        private string _name;
        private string _sku;
        private int _baseQuantity;
        private int _unitOfMeasure;
        private decimal _amount;
        private bool _exported;

        

        public InvoiceItem(IInvoiceItemItemization itemization)
        {            
            _itemization = itemization;                 
        }

        #region Implementation of IInvoiceItem
        

        public int? ParentId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int InvoiceId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ShipmentId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IInvoiceItemItemization Itemization
        {
            get { return _itemization; }
        }

        public InvoiceItemTypeField InvoiceItemType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Sku
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int BaseQuantity
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int UnitOfMeasure
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Amount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Exported
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }



        #endregion


        #region Implementation of IItemization        

        public decimal Total()
        {
            return Itemization.Total();
        }

        #endregion
    }
}
