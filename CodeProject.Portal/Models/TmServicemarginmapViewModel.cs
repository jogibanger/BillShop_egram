using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmServicemarginmap
 {


 public  Int32? Serviceid { get; set; }

 public  Int32? Agencyid { get; set; }

 public  Int32? Margintypeid { get; set; }

 public  string Proptypeontxnfee { get; set; }

 public  decimal? Agencypropontxnfee { get; set; }

 public  decimal? Onespropontxnfee { get; set; }

 public  decimal? Mdspropontxnfee { get; set; }

 public  decimal? Dspropontxnfee { get; set; }

 public  decimal? Agentpropontxnfee { get; set; }

 public  string Proptypeonmarginfromagency { get; set; }

 public  decimal? Onesproponmarginfromagency { get; set; }

 public  decimal? Mdsproponmarginfromagency { get; set; }

 public  decimal? Dsproponmarginfromagency { get; set; }

 public  decimal? Agentproponmarginfromagency { get; set; }

 public  string Status { get; set; }

}
