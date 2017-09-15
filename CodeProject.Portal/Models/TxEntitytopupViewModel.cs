using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxEntitytopup
 {


 public  decimal? Topupid { get; set; }

 public  decimal? Entityid { get; set; }

 public  decimal? Topupfromid { get; set; }

 public  DateTime? Topupdatetime { get; set; }

 public  decimal? Topupamount { get; set; }

 public  Int32? Topupmode { get; set; }

 public  string Originatorname { get; set; }

 public  string Originatorbank { get; set; }

 public  string Instrumentref { get; set; }

 public  DateTime? Instrumentdate { get; set; }

 public  string Beneaccount { get; set; }

 public  string Benebank { get; set; }

 public  string Benebankcode { get; set; }

 public  string Remarks { get; set; }

 public  string Status { get; set; }

 public  DateTime? Createddate { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Approvedby { get; set; }

 public  string Reason { get; set; }

 public  decimal? Importid { get; set; }

 public  string Proofimg { get; set; }

}
