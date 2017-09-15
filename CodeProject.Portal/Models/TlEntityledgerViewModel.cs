using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TlEntityledger
 {


 public  decimal? Ledgerid { get; set; }

 public  decimal? Entityid { get; set; }

 public  DateTime? Ledgerdate { get; set; }

 public  Int32? Type { get; set; }

 public  string Narration { get; set; }

 public  string Dbcr { get; set; }

 public  decimal? Amount { get; set; }

 public  decimal? Limit { get; set; }

 public  string Referenceid { get; set; }

 public  string Remarks { get; set; }

}
