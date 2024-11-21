<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Student Club</title>
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

$sql="INSERT INTO $table_name(Name,Sid,Contact_no,Email,Gender)
VALUES('$_POST['fname]','$_POST[ssid]','$_POST[telno]',
       '$_POST[email]','$_POST[gender]')";

echo "<div class=entries>";
echo "<h3 align=center>Add Database Record</h3>";
print "<center>";

if (!mysqli_query($connect,$sql))
{
    die('Error: ' . mysqli_error($connect));
}
echo "<center>Successfully added</center>";
mysqli_close($connect);
print "</center>";
echo "</div>";
?>
</body>
</html>
