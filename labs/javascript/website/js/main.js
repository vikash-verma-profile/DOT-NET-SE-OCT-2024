var users = [];
var counter = 0;



function register() {
    counter=localStorage.getItem('counter') || 0;
    users = JSON.parse(localStorage.getItem('users')) || [];
    var user = {
        email: document.getElementById('txtEmail').value,
        password: document.getElementById('txtPassword').value
    };
    users[counter] = user;
    counter++;
    localStorage.setItem('users', JSON.stringify(users));
    localStorage.setItem('counter', counter);
    window.location.href = "login.html";
}

function login() {

    users = JSON.parse(localStorage.getItem('users'));
    var email = document.getElementById('txtEmail').value;
    var password = document.getElementById('txtPassword').value;
    console.log(users);
    for(var i=0;i<users.length;i++){
        if(email===users[i].email && password === users[i].password)
        {
            localStorage.setItem("loggedIn",true);
            window.location.href="dashboard.html";
        }
    }
    
}

function checkLogin(){

    var loggedIn=localStorage.getItem("loggedIn") || false;
    if(loggedIn){
        document.getElementById('login').style.display="none";
        document.getElementById('register').style.display="none";
        document.getElementById('dashboard').style.display="inline";
        document.getElementById('logout').style.display="inline";
    }
    else{
        document.getElementById('login').style.display="inline";
        document.getElementById('register').style.display="inline";
        document.getElementById('dashboard').style.display="none";
        document.getElementById('logout').style.display="none";
    }
}
function logOut(){
    localStorage.removeItem("loggedIn") ;
    window.location.href = "login.html";

}
checkLogin();


//functions


//cookies


