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
    echo "<div class=entries>";    
    echo "<center><h3>Logged out successfully</h3></center><br>"; 
    session_start();
    session_destroy(); 
    echo "</div>";   
 
?>
 
</body>
</html>