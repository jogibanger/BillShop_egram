using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmAgentregisterpaymentlog
 {


 public  decimal? Id { get; set; }

 public  Int32? Bank { get; set; }

 public  string Bankname { get; set; }

 public  string Bankaccountno { get; set; }

 public  Int32? Mode { get; set; }

 public  string Amount { get; set; }

 public  DateTime? Transferdate { get; set; }

 public  string Referenceno { get; set; }

 public  string Status { get; set; }

 public  decimal? Userid { get; set; }

 public  string Requestby { get; set; }

 public  DateTime? Requestdate { get; set; }

 public  string Payutxn { get; set; }

 public  string Approvedby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Remarks { get; set; }

}
