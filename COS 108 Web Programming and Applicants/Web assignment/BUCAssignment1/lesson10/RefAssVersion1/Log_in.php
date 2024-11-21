<!DOCTYPE html>
<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Student Club</title>
          <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
</head>
<body>
<center>
<img src="TMC-Logo-3.jpg" margin="auto" width="370px" height="110px"></img>
<p>
<nav>
   <div class="topnav" id="myTopnav">
        <a href="L3TutoHome.html">Home</a>
      <a href="L3TutoAbout.html">About the Club</a>
      <a href="L3Tutophoto.html">Photo Gallery</a>
      <a href="L3TutoRegistration.html">Member Registration</a>
      <a href="L3TutoLogin.html">Admin Login</a>
   </div>
</nav>
</p>
</center>
<?php
$host = "localhost";
$user = "root";
$passwd = "";
$database = "bucdb";
$table_name = "user";

$connect = mysqli_connect($host,$user,$passwd,$database) 
            or die("could not connect to database");

$username = $_POST['username'];  
$password = $_POST['password'];

$sql = "select * from $table_name where user_name = '$username' and user_pwd = '$password'";  
$result = mysqli_query($connect, $sql);  
$row = mysqli_fetch_array($result, MYSQLI_ASSOC);  
$count = mysqli_num_rows($result);  
                  
    if($count == 1){        
        echo "<h1><center> Login successful !!!</center></h1>";
        print "<p>You can operate the following operation!!!</p>";
        print "<p><a href=AdminAdd.html>Add New Member Record</a></p>";
        print "<p><a href=AdminView.php>View Database Record</a></p>";
        print "<p><a href=AdminEdit.php>Edit Database Record</a></p>";
        print "<p><a href=AdminDelete.php>Edit Database Record</a></p>";  
        
        }  
        else{  
            echo "<h1> Login failed. Invalid username or password.</h1>";  
        }     
?> 
</body>
</html> 