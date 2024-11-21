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
</center>
<?php
print "<hr>";
print "<center><p>Add New Database Record</p></center>";
$host = "localhost";
$user = "root";
$passwd = "";
$database = "bucdb";
$table_name = "member";

$connect = mysqli_connect($host,$user,$passwd,$database) 
or die("could not connect to database");

$sql="INSERT INTO $table_name(m_name,s_id,phone_no,email,gender)
VALUES('$_POST[fname]','$_POST[ssid]','$_POST[telno]',
       '$_POST[email]','$_POST[gender]')";

if (!mysqli_query($connect,$sql))
{
    die('Error: ' . mysqli_error($connect));
}
echo "<center>Successfully added</center>";
mysqli_close($connect);
?>
</body>
</html>
