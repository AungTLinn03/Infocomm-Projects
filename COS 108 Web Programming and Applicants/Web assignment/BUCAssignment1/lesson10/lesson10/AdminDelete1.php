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
$database = "bucdb";
$table_name = "member";

$connect = mysqli_connect($host,$user,$passwd,$database) or
die("could not connect to database");

mysqli_select_db($connect,$database);

$member_id = $_POST["dmid"];
$query = "SELECT * FROM $table_name WHERE id='".$member_id."'";
$sql = "DELETE FROM $table_name WHERE id='".$member_id."'";
mysqli_select_db($connect,$database);
$result = mysqli_query($connect,$query);
$myrow = mysqli_fetch_array($result,MYSQLI_ASSOC);
echo "<div class=entries>";
echo "<h3 align=center>Delete Database Record</h3>";
print "<center>";
if (!$myrow)
{
print "<p>No such record</p>";
}
else 
{
mysqli_query($connect,$sql);
print "Member ID '$member_id' has been deleted from the Database";
}
mysqli_close($connect);
print "</center>";
echo "</div>";
?>
</body>
</html>