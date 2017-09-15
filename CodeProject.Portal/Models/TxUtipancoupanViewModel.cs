using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxUtipancoupan
 {


 public  decimal? Id { get; set; }

 public  decimal? Totalcoupan { get; set; }

 public  decimal? Totalamount { get; set; }

 public  DateTime? Coupantopupdate { get; set; }

 public  string Requestby { get; set; }

 public  string Approvedby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Reference { get; set; }

 public  decimal? Txnid { get; set; }

 public  DateTime? Txndate { get; set; }

 public  string Panusercode { get; set; }

 public  string Status { get; set; }

 public  string Reason { get; set; }

}
