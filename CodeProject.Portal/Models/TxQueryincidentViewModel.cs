using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxQueryincident
 {


 public  decimal? Incidentid { get; set; }

 public  string Title { get; set; }

 public  string Description { get; set; }

 public  Int32? Incidenttypeid { get; set; }

 public  string Contactname { get; set; }

 public  string Contactemail { get; set; }

 public  string Contactmobile { get; set; }

 public  decimal? Transactionid { get; set; }

 public  string Status { get; set; }

 public  DateTime? Loggeddate { get; set; }

 public  string Loggedby { get; set; }

 public  DateTime? Closeddate { get; set; }

 public  string Closedby { get; set; }

 public  Int32? Incidentcateid { get; set; }

 public  string Assignedby { get; set; }

 public  Int32? Userid { get; set; }

 public  DateTime? Assigneddate { get; set; }

 public  string Complaintimage { get; set; }

}
