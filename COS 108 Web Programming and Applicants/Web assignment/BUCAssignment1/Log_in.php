<!DOCTYPE html>
<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Tennis Club</title>
          <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
          <style>
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
<nav>
         <a href="index.html"></a>
         <img src="TMClogo.png" width="200px" height="200px">
           <div class="nav-links" id="navLinks">
           <a href="AdminView.php">View Members</a>
           <a href="AdminAdd.php">Add New Member</a>
           <a href="AdminEdit.php">Edit Member</a>
           <a href="AdminDelete.php">Delete Member</a>
           <a href="Log_out.php">Log Out</a>  
                      
               </div>
             </nav>
 <div class="chimp">           

<?php
$host = "localhost";
$user = "root";
$passwd = "";
$database = "tennis";
$table_name = "user";

$connect = mysqli_connect($host,$user,$passwd,$database) 
            or die("could not connect to database");

$username = $_POST['username'];  
$password = $_POST['password'];

$sql = "select * from $table_name where username = '$username' and password = '$password'";  
$result = mysqli_query($connect, $sql);  
$row = mysqli_fetch_array($result, MYSQLI_ASSOC);  
$count = mysqli_num_rows($result); 

echo "<div>";
             
    if($count == 1){
        session_start();
        //$_SESSION['sid']=$uid;
        $_SESSION['sid']=session_id();      
        header("Location:AdminWelcome.html");       
        }  
        else{  
            echo "<center><h3> Login failed. Invalid username or password.</h3><center>";  
        }
echo "</div>";
?> 
</div> 
</body>
</html> 