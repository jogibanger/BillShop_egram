using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmSbicspdata
 {


 public  decimal? Id { get; set; }

 public  string Cspname { get; set; }

 public  string Mobileno { get; set; }

 public  string Emailid { get; set; }

 public  Int32? Category { get; set; }

 public  Int32? State { get; set; }

 public  Int32? District { get; set; }

 public  string Pincode { get; set; }

 public  string Accountno { get; set; }

 public  string Pancard { get; set; }

 public  string Aadhar { get; set; }

 public  string Panchayat { get; set; }

 public  string Block { get; set; }

 public  string Linkbranchname { get; set; }

 public  string Linkbranchcode { get; set; }

 public  string Status { get; set; }

 public  string Remarks { get; set; }

}
