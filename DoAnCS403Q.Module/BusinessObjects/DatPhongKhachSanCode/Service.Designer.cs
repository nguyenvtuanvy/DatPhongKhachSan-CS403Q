﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DoAnCS403Q.Module.BusinessObjects.DatPhongKhachSan
{

    [DefaultProperty("name")]
    public partial class Service : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        decimal fprice;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")]
        public decimal price
        {
            get { return fprice; }
            set { SetPropertyValue<decimal>(nameof(price), ref fprice, value); }
        }
        [Association(@"Room_ServiceReferencesService"), Aggregated]
        public XPCollection<Room_Service> Room_Services { get { return GetCollection<Room_Service>(nameof(Room_Services)); } }
    }

}
