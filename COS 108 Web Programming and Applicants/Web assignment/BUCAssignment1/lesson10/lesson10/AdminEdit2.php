<html>
<head>
           <meta charset = 'utf-8'>
           <title>View Database Record</title>
           <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
           <script language="javascript" type="text/javascript" src="Special.js">
           </script>
</head>
<body>
<center>
<img src="TMC-Logo-3.jpg" margin="auto" width="370px" height="110px"></img>
<p>
<nav>
   <div class="topnav" id="myTopnav">
        <a href="AdminView.php">View Members</a>
      <a href="AdminAdd.html">Add New Member</a>
      <a href="AdminEdit.php">Edit Member</a>
      <a href="AdminDelete.php">Delete Member</a>
      <a href="Log_out.php">Log Out</a>      
   </div>
</nav>
</p>
</center>
<?php

$host = "localhost";
$user = "root";
$passwd = "";
$database = "tennis";
$table_name = "member";

$connect = mysqli_connect($host,$user,$passwd,$database) 
or die("could not connect to database");

mysqli_select_db($connect,$database);

$member_id =$_POST["m_id"];
$name =$_POST["edname"];
$student_id =$_POST["edsid"];
$phone_no=$_POST["edphone"];
$email =$_POST["edemail"];
$gender =$_POST["edgender"];

$sql="UPDATE $table_name SET m_name = '$Name',s_id='$Sid',phone_no='$Contact_no',
email='$Email',gender='$email'WHERE id = '".$Mid."'";

echo "<div class=entries>";
echo "<h3 align=center>Edit Database Record</h3>";
print "<center>";
if (!mysqli_query($connect,$sql))
{
die('Error: ' . mysqli_error($connect));
}
print "<p>Your information has been updated in the database</p>";
mysqli_close($connect);
print "</center>";
echo "</div>";
?>
</body>
</html>