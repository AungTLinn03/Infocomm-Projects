<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Tennis Club</title>
           <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
           <script language="javascript" type="text/javascript" src="Special.js">
           </script>
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
   
   <div class="nav-links" id="navLinks">
   <a href="AdminView.php">View Members</a>
   <a href="AdminAdd.php">Add New Member</a>
   <a href="AdminEdit.php">Edit Member</a>
   <a href="AdminDelete.php">Delete Member</a>
   <a href="Log_out.php">Log Out</a>      
</div>
</nav>
<p>
<p>
<p>

<div class=chimp>
<?php
//print "<p>Edit Database Record</p>";
?>

<center>
   <table>
<table border=0 cellpadding=5 align="center">

<tr><td colspan="3"><center><h1>Edit Database Record</h1></td></tr></center></table>
<p>
<tr>
<td><h1>EDIT ID:</h1></td>
<form name="AdminEditForm1" action ="AdminEdit1.php" method="post">
</tr>
            
<p>
<tr>
<td>Member ID:</td>
<td><input type="text" name="m_id" size="50"></td>
</tr>
<p>

<tr>
<td colspan="2"><input type="submit" value="submit" style="height:50px; width:80px; vertical-align:middle;"/>
                <input type="reset" value="Reset Form" style="height:50px; width:80px; vertical-align:middle;"/></td>
</tr>
</table>
</form>
</center>
</div>
</body>
</html>