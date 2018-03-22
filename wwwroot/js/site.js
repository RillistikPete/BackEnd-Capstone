// Write your Javascript code.
                
            $(document).ready(function(){
                $("#submitModal").on("click", function(event){
                    var input = $("#input").val();
                    switch(input) {
                        case "Doctor2017!!":
                            window.location.href = "http://localhost:5000/Account/RegisterDocOrPat/Doctor";
                            break;
                        default:
                            alert("Access Denied");
                            //event.preventDefault();
                            break;
                    };
                });
            });