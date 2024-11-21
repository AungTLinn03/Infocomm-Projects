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
         
           <div class="nav-links" id="navLinks">
               <a href="index.html">Home</a>
                      <a href="about.html">About</a>
                      <a href="photo.html">Photo</a>
                      <a href="L3TutoRegistration.php">Registration</a>
                      <a href="login.html">Login</a>
                      
               </div>
             </nav>
             <p>
             <p>
             <p>
             <p>
             <p>
             <p>
 
<?php    
    echo "<div class=sheep>";    
    echo "<center><h3>Logged out successfully...</h3></center><br>"; 
    session_start();
    session_destroy(); 
    echo "</div>";   
 
?>
 
</body>
</html>