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
//print "<p>Delete Database Record</p>";
?>
<div class="entries">
<h1 align="center">Delete Database Record</h1>
<center>
<p>Please enter the Product ID you want to delete</p>
<form name="AdminDeleteForm" action ="AdminDelete1.php" method="post">
<table>
<tr>
<td>Member ID</td>
<td><input type="text" name="dmid" size="10"></td>
</tr>
<tr>
<td colspan="2"><input type="submit" value="submit"/>
                <input type="reset" value="Reset Form"/></td>
</tr>
</table>
</form>
</center>
</div>
</body>
</html>
