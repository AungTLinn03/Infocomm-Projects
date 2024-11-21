<!DOCTYPE html>
<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Tennis Club</title>
          <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
          <style>  
             .error {color:white;}  
             body{
             background-image:url('../BUCAssignment1/purpleback.jpg');
             background-position:cover;
             background-repeat: no repeat;
             background-position: center;
             height:100%;
             width:100%;
             
             
             }
          </style>          
</head>

<body>
<?php
$nameErr = $sidErr = $emailErr = $contactErr = $genderErr = "";  
$name = $sid = $email = $contact = $gender = "";  
  
//Input fields validation  
if ($_SERVER["REQUEST_METHOD"] == "POST") {  
      
    //String Validation  
        if (empty($_POST["fname"])) 
        {  
             $nameErr = "Name is required";  
        } else 
        {  
            $name = input_data($_POST["fname"]);  
                // check if name only contains letters and whitespace  
            if (!preg_match("/^[a-zA-Z ]*$/",$name)) {  
                    $nameErr = "Only alphabets and white space are allowed";  
            }  
        } 
        
        if (empty($_POST["ssid"])) {  
            $sidErr = "Student id is required";  
        } 
        else{
            $sid=$_POST["ssid"];
        }   
        
        //Email Validation   
        if (empty($_POST["email"])) {  
                $emailErr = "Email is required";  
        } else {  
                $email = input_data($_POST["email"]);  
                // check that the e-mail address is well-formed  
                if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {  
                    $emailErr = "Invalid email format";  
                }  
        }    
        //phone Number Validation  
        if (empty($_POST["telno"])) {  
                $contactErr = "Contact number is required";  
        } else {  
                $contact = input_data($_POST["telno"]);  
                // check if mobile no is well-formed  
                if (!preg_match ("/^[0-9]*$/", $contact) ) {  
                    $contactErr = "Only numeric value is allowed.";  
                    } 
        }  
        if (empty ($_POST["gender"])) {  
            $genderErr = "Gender is required";  
         } else {  
            $gender = input_data($_POST["gender"]);  
        }  
    }
    function input_data($data) {  
        $data = trim($data);  
        $data = stripslashes($data);  
        $data = htmlspecialchars($data);  
        return $data;  
      }  
      ?>

   <nav>
   
           <div class="nav-links" id="navLinks">
           <a href="AdminView.php">View Members</a>
           <a href="AdminAdd.php">Add New Member</a>
           <a href="AdminEdit.php">Edit Member</a>
           <a href="AdminDelete.php">Delete Member</a>
           <a href="Log_out.php">Log Out</a>      
      </div>
   </nav>
   
<div class="you">
    <center>
    <form name="registerForm" action ="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
    <table border=0 cellpadding=5 align="center">
    <tr><td colspan="2"><center><h1>Add New Data</h1></center></td></tr>
    <tr><td><center><span class = "error">* required field </span></center></td></tr>

<table border=0 cellpadding=5 align="center">
<tr>
   <td>Full Name:</td>
   <td><input type="text" name="fname" size="50">
       <span class="error">* <?php echo $nameErr; ?> </span></td>
</tr>
<tr>
<td>Student ID:</td>
<td><input type="text" name="ssid" size="50">
    <span class="error">* <?php echo $sidErr; ?> </span></td></tr>
<tr>
   <td>Contact No.:</td>
   <td><input type="text" name="telno" size="50">
   <span class="error">* <?php echo $contactErr; ?> </span></td>
</tr>
<tr>
    <td>E-Mail Address:</td>
    <td><input type="text" name="email" size="50">
    <span class="error">* <?php echo $emailErr; ?></span></td>
</tr>
<tr>
     <td>Gender</td>
     <td><input type="radio" name="gender" value="Male" style="height:20px; width:20px; vertical-align:middle;">Male
             <input type="radio" name="gender" value="Female"style="height:20px; width:20px; vertical-align:middle;">Female
             <span class="error">* <?php echo $genderErr; ?></span>
     </td>
</tr>
<tr>
    <td colspan=2 style="text-align:center">
    <input type="submit" name="submit" value="submit" style="height:50px; width:80px; vertical-align:middle;">
    <input type="reset" value="Reset Form" style="height:50px; width:80px; vertical-align:middle;">
    </td>
</tr>
</table>
</form>
    </center>
    </div>
    <div class="sed">
<?php  
    if(isset($_POST['submit'])) 
    { 
        
    if($nameErr=="" && $sidErr=="" && $emailErr=="" && $contactErr=="" && $genderErr=="") {
      $host = "localhost";
      $user = "root";
      $passwd = "";
      $database = "tennis";
      $table_name = "member";

       $connect = mysqli_connect($host,$user,$passwd,$database) 
       or die("could not connect to database");

      $sql="INSERT INTO $table_name(Name,Sid,Contact_no,Email,Gender)
      VALUES('$_POST[fname]','$_POST[ssid]','$_POST[telno]',
       '$_POST[email]','$_POST[gender]')";

       if (!mysqli_query($connect,$sql))
       {
           die('Error: ' . mysqli_error($connect));
       }
       else{       
       echo "<center>Successfully added</center>";       
       }
       mysqli_close($connect);    
   }
   else{      
        echo "<center><b>You didn't filled up the form correctly.</b></center>";  
       } 
   }
?>
</div>
</body>
</html>




