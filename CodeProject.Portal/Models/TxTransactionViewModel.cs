using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxTransaction
 {


 public  decimal? Transactionid { get; set; }

 public  decimal? Entityid { get; set; }

 public  Int32? Serviceid { get; set; }

 public  Int32? Agencyid { get; set; }

 public  string Reference { get; set; }

 public  DateTime? Txndatetime { get; set; }

 public  string Txntype { get; set; }

 public  decimal? Txnamount { get; set; }

 public  decimal? Txnfee { get; set; }

 public  decimal? Marginfromagency { get; set; }

 public  string Description { get; set; }

 public  string Relatedreference { get; set; }

 public  string Info1 { get; set; }

 public  string Info2 { get; set; }

 public  string Info3 { get; set; }

 public  string Info4 { get; set; }

 public  string Info5 { get; set; }

 public  string Info6 { get; set; }

 public  string Info7 { get; set; }

 public  string Info8 { get; set; }

 public  string Status { get; set; }

 public  DateTime? Createddate { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Canceldate { get; set; }

 public  string Cancelby { get; set; }

 public  string Canceltype { get; set; }

 public  decimal? Cancelcharge { get; set; }

 public  decimal? Cancelledamount { get; set; }

 public  string Reason { get; set; }

}
