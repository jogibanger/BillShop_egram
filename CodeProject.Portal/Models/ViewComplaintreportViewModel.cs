using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  ViewComplaintreport
 {


 public  decimal? Incidentid { get; set; }

 public  string Title { get; set; }

 public  string Description { get; set; }

 public  string Assignedby { get; set; }

 public  Int32? Incidenttypeid { get; set; }

 public  string Incidenttype { get; set; }

 public  string Contactname { get; set; }

 public  string Contactemail { get; set; }

 public  string Contactmobile { get; set; }

 public  Int32? Userid { get; set; }

 public  decimal? Transactionid { get; set; }

 public  string Status { get; set; }

 public  DateTime? Loggeddate { get; set; }

 public  string Loggedby { get; set; }

 public  DateTime? Closeddate { get; set; }

 public  string Closedby { get; set; }

 public  DateTime? Assigneddate { get; set; }

 public  Int32? Mrgid { get; set; }

 public  byte[] Complaintimage { get; set; }

 public  Int32? Incidentcateid { get; set; }

 public  Int32? Assignediffvalue { get; set; }

 public  Int32? Datedifference { get; set; }

 public  string Resolve { get; set; }

 public  string Assigneddiff { get; set; }

 public  string Usercode { get; set; }

}
