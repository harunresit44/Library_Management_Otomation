<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatabaseProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
 
            <div class="container">

                <div class="row mb-5 mt-4">

                
                <div class="xcontainerx">
                  <div class="upper">Library Management</div>
                  <div class="lower">Library Management</div>
                  <div class="inside">DataBase Project</div>
                </div>
        </div>

            <div class="row mt-6 mb-6 p-4 d-flex justify-content-around">

                 <div class="login-box col-5 mb-6 mx-3">
                <h2>Adding Book</h2>
         
                <div class="user-box">
                 
                    <asp:TextBox ID="tbxkitapad"  runat="server"  ></asp:TextBox>
                    <label>Book Name</label>
                     <%--<asp:Label ID="Label1"  runat="server" Text="Book Name" ></asp:Label>--%>

                </div>
                <div class="user-box">

                    <asp:TextBox ID="tbxyazarad"  runat="server"  ></asp:TextBox>

                    <label>Writer Name</label>
                    <%--<asp:Label ID="Label2"   runat="server" Text="Writer Name"></asp:Label>--%>

                </div>
                <div class="user-box">

                    <asp:TextBox ID="tbxpage"  runat="server" ></asp:TextBox>

                    <label>Page Count</label>
                    <%-- <asp:Label ID="Label3"  runat="server" Text="Page    "></asp:Label>--%>

                </div>
            
                <div class="user-box">

                    <asp:TextBox ID="tbxbooknumber"  runat="server" ></asp:TextBox>

                    <label>Number of Book(s)</label>
                    <%--<asp:Label ID="Label6"  runat="server" Text="Number of Books"></asp:Label>--%>


                </div>
                     <%--<div class="row d-flex justify-content-between">
                    
                     <div>
                          <asp:CheckBox ID="beniHatirla" Text="&nbsp;Beni Hatırla" runat="server" />
                    </div>
                   <a  data-toggle="modal" data-target="#modal-instagram" class="">Şifremi Unuttum</a>

                </div>--%>
            
                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                  
                    <asp:Button  type="button" CssClass="girisBtn"  ID="btnekle" runat="server" Height="40px" OnClick="btnekle_Click" Text="Add" Width="88px" />
                </div>


                 


        </div>

                <div class="login-box my-5 col-5 mx-3">
                <h2>Adding number of Book</h2>
         
                <div class="user-box">
                 
                    <asp:TextBox ID="tbxaddingbookname" runat="server"></asp:TextBox>
                    <label>Book Name</label>

                </div>
                <div class="user-box">

                    <asp:TextBox ID="tbxaddingbooknumber" runat="server"></asp:TextBox>
                    <label>How many to add</label>
                </div>
        
            
                <div class="girisDiv mt-1">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                  
                   <asp:Button type="button" CssClass="girisBtn" ID="btnbookadd" runat="server" OnClick="btnbookadd_Click" Text="INCREASE / DECREASE" />
                </div>


                <div class="user-box mt-4">

                    <asp:TextBox ID="tbxıdnumber" runat="server"></asp:TextBox>
                    <label>Book ID that you ant to delete</label>
                </div>

                 <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>
                  
                     <asp:Button type="button" CssClass="girisBtn" ID="btnsil" runat="server" Height="40px" Text="Delete" Width="88px" OnClick="btnsil_Click" />


                </div>


        </div>

                <div class="col-12 mt-4">
                    <asp:GridView ID="GridViewBook" CssClass="col-12" runat="server" style="margin-bottom: 0px" >
                    </asp:GridView>

                    </div>

            </div>
            

           
            
            
            <%--<asp:Button ID="btnguncelle" runat="server" Height="40px" Text="Update" Width="88px" OnClick="btnguncelle_Click" />--%>

            <asp:Button ID="btnlistele" runat="server" type="button" CssClass="girisBtn" OnClick="btnlistele_Click" Text="Refresh Table"  />
            
            <br />
            <br />


            

            <br />

            <br />





            
           

             

            <br />



                  <div class="row my-5">

                 <div class="login-box col-3">
                <h2>New Student</h2>
         
                <div class="user-box">
                 <asp:TextBox ID="tbxstudentname" runat="server" ></asp:TextBox>
                    <label>Student Name</label>
             

                </div>
                <div class="user-box">

                    
          
            <asp:TextBox ID="tbxstudentsurname" runat="server" ></asp:TextBox>
                    <label>Student Surname</label>

                </div>
                <div class="user-box">
                    <asp:TextBox ID="tbxstudentid" runat="server" ></asp:TextBox>
                    <label>Student School ID</label>
                </div>

       
            
                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

                    <asp:Button type="button" CssClass="girisBtn" ID="btnstudentinsert" runat="server" Height="40px" 
                        OnClick="btnstudentinsert_Click" Text="NEw Student"  />
                
                </div>

                      <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>




                 <asp:Button type="button" CssClass="girisBtn" ID="btnstudentdelete" runat="server" Text="Delete" OnClick="btnstudentdelete_Click" />

               
                
                </div>

            <div class="user-box mt-4">
                     <asp:TextBox ID="tbxstudentoldıd" runat="server" ></asp:TextBox>
                    <label>StudentID</label>
                </div>
                    

           

                     <div class="row"></div>

              <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>



                  <asp:Button type="button" CssClass="girisBtn" ID="btnstudentupdate" runat="server"  Text="Update"  OnClick="btnstudentupdate_Click" />


                </div>
        </div>


                <div class="col-9">
                    <asp:GridView ID="GridViewStudent"  Width="100%" runat="server"  style="margin-bottom: 0px">
                    </asp:GridView>

                    </div>

                       <div class="girisDiv mt-2">
                            <span></span>
                            <span></span>
                            <span></span>
                            <span></span>

                        <asp:Button type="button" CssClass="girisBtn" ID="btnstudentview" runat="server" OnClick="btnstudentview_Click" Text="Refresh Table"  />


                </div>

            </div>

    
        
           

            

            <br />

                <div class="row mt-5 mb-5">

                 <div class="login-box col-3">
                <h2>Book Borrowing</h2>
         
                <div class="user-box">
                 <asp:TextBox ID="tbxbooknameborrow" runat="server"></asp:TextBox>
                    <label>Book Name</label>
             

                </div>
                <div class="user-box">

                    <asp:TextBox ID="tbxstudentidborrow" runat="server"></asp:TextBox>
                    <label>Student School ID</label>

                </div>
               

       
            
                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

 
                    <asp:Button type="button" CssClass="girisBtn" ID="btnborrowinsert" runat="server" 
                        OnClick="btnborrowinsert_Click" Text="Student Take Book" />

                </div>

                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

 

                      <asp:Button type="button" CssClass="girisBtn" ID="btnborrowupdate" runat="server"  OnClick="btnborrowupdate_Click" Text="Student Give Back" />



                </div>
                     


        </div>


                <div class="col-9">
                    <asp:GridView ID="GridViewBorrow" Width="100%" runat="server" >
            </asp:GridView>

                    </div>

                    <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

 
            <asp:Button type="button" CssClass="girisBtn" ID="btnborrowview" runat="server"  OnClick="btnborrowview_Click" Text="Refresh Table" />





                </div>
            </div>

       




            <div class="row my-5 mt-5 mb-5">

                 <div class="login-box col-3">
                <h2>Fine</h2>
         
                <div class="user-box">

                    <asp:TextBox ID="tbxfinepayedamount" runat="server"></asp:TextBox>
                
                    <label>Student Number ID</label>

                </div>

                    
            
                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

                     <asp:Button type="button" CssClass="girisBtn" ID="btnfinepaid" runat="server"  Text="Paid"  OnClick="btnfinepaid_Click" />
 

                </div>

               <div class="user-box">

                   <asp:TextBox ID="tbxfineoldid" runat="server"></asp:TextBox>

                
                    <label>FineID (Delete fine of Student)</label>

                </div>

                    
            
                <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

            <asp:Button type="button" CssClass="girisBtn"  ID="btnfinedelete" runat="server"  Text="Delete"  OnClick="btnfinedelete_Click" />

               
 

                </div>



        </div>


                <div class="col-9">
                   <asp:GridView ID="GridViewFine" runat="server">
                     </asp:GridView>

                  </div>

                   <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>


                     <asp:Button type="button" CssClass="girisBtn" ID="btnfineview" runat="server"  OnClick="btnfineview_Click" Text="Refresh Table"  />


                </div>

            </div>
           
 

     
            <br />


           <div class="row mt-5 mb-5 my-5">

                 <div class="login-box col-3">
                <h2>Taken Dates</h2>
         
                <%--<div class="user-box">

                    <asp:TextBox ID="tbxtakendate" runat="server"></asp:TextBox>

                    <label>Taken Date</label>
             

                </div>
                <div class="user-box">

                 <asp:TextBox ID="tbxgivendate" runat="server" ></asp:TextBox>

                
                    <label>Given Date</label>

                </div>--%>
         

       
   



        </div>


                <div class="col-9">
                   <asp:GridView Width="100%" ID="GridViewTaken" runat="server">
            </asp:GridView>

                  </div>

               <div class="girisDiv mt-2">
                    <span></span>
                    <span></span>
                    <span></span>
                    <span></span>

            <asp:Button type="button" CssClass="girisBtn" ID="btntakenview" runat="server" OnClick="btntakenview_Click" Text="Refresh Table" />


 


                </div>

            </div>


            <br />
            <br />
      
           
           
            <br />

            <br />
            <br />
            

                </div>

        </div>
    </form>

</body>

    <script src="Scripts/jquery-3.3.1.min.js"></script>
<script src="Scripts/popper.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

</html>
