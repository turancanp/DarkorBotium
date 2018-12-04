(function () {
 let cos  = "dupa";
    function getScript(url, success) {
        var script = document.createElement('script');
        script.src = url;
        var head = document.getElementsByTagName('head')[0],
            done = false;
      
        script.onload = script.onreadystatechange = function () {
            if (!done && (!this.readyState
                || this.readyState == 'loaded'
                || this.readyState == 'complete')) {
                done = true;
                success();
                script.onload = script.onreadystatechange = null;
                head.removeChild(script);
            }
        };
        head.appendChild(script);
    }
    getScript('https://code.jquery.com/jquery-latest.min.js', function () {
        if (typeof jQuery == 'undefined') {
            
        } else {
          
			var connect_status = false;
			
            $(document).ready(function () {
			
                $(document).on('packet', function (e) {
                    (async function() {
                        await CefSharp.BindObjectAsync("cmdjs", "bound");

                        cmdjs.packedfromjs(e.originalEvent.detail);
                    })();
				
			//	cmdjs.packedfromjs(e.originalEvent.detail);
					
				
			   });
                $(document).on('targetstatus',function(e){
                    console.log(e.originalEvent.detail);
                    (async function() {
                        await CefSharp.BindObjectAsync("cmdjs", "bound");

                        cmdjs.targetstate(e.originalEvent.detail);
                    })();
			
					
				
			   });
			    $(document).on('disconnected',function(e){
			        connect_status = false;
			        (async function() {
			            await CefSharp.BindObjectAsync("cmdjs", "bound");

			            cmdjs.disconnect();
			        })();
				//	cmdjs.disconnect();
				
						
			   });
			     $(document).on('connected',function(e){
			         connect_status = true;
			         (async function() {
			             await CefSharp.BindObjectAsync("cmdjs", "bound");

			             cmdjs.connected();
			         })();
				//	cmdjs.connected();
				
			   });
			   
			        $(document).on('movedone',function(e){
			            (async function() {
			                await CefSharp.BindObjectAsync("cmdjs", "bound");

			                cmdjs.movecomplete();
			            })();
				//	cmdjs.movecomplete();
				
			   });
			   
				 $(document).on('flashsecurityerror',function(e){
				
			
				
			   });
			   
			    $(document).on('socketerror',function(e){
				
				
				
			   });
			   
			   setInterval(function(){
				   if(connect_status){
				var position = document.getElementById("preloader").position();
				var position_splited = position.split("|");
				(async function() {
				    await CefSharp.BindObjectAsync("cmdjs", "bound");

				    cmdjs.player(position_splited[0],position_splited[1],position_splited[3]);
				})();
				cmdjs.player(position_splited[0],position_splited[1],position_splited[3]);
			//
				   }
			   }, 150);
			   
			   
             
            })
        }
    });
})();