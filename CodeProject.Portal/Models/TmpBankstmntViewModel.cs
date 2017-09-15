using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmpBankstmnt
 {


 public  DateTime? Valuedate { get; set; }

 public  string Referenceno { get; set; }

 public  string Description { get; set; }

 public  decimal? Debit { get; set; }

 public  decimal? Credit { get; set; }

 public  decimal? Balance { get; set; }

}
