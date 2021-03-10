<script>
	let questions = [];
	let answers = new Array(questions.length).fill(null);
	let questionPointer = -1;

	function getScore(){
			let score = answers.reduce((acc,val,index)=>{
				if(questions[index].correctIndex == val){
					return acc+1;
				}
				return acc;
			},0);
			return (score/questions.length * 100)+"%";
		}
</script>

<style>
	
</style>

<div class="app">
	{#if questionPointer==-1}
		<div class="start-screen">
			<button on:click={()=>{questionPointer=0}}>
				Start Quiz
			</button>	
		</div>
	{:else if !(questionPointer > answers.length-1)}
		<div class="quiz-screen">
			<div class="main">
				<h2>
					{questions[questionPointer].question}
				</h2>
				<div class="options">
					{#each questions[questionPointer].options as opt,i}
						<button class="{answers[questionPointer]==i?'selected':''}" on:click={()=>{answers[questionPointer]=i}}>
							{opt}	
						</button>
					{/each}
				</div>
			</div>
			<div class="footer">
				<div class="buttons">
					<button disabled={questionPointer==0} on:click={()=>{questionPointer--}}>
						&lt;
					</button>
					<button on:click={()=>{questionPointer++}}>
						&gt;
					</button>
				</div>
			</div>
		</div>
	{:else}
		<div id="fb-root"></div>
		<script async defer crossorigin="anonymous"
				src="https://connect.facebook.net/bg_BG/sdk.js#xfbml=1&version=v10.0"
				nonce="XFt0SvXB">
		</script>
		<div class="score-screen">
			<h1>
				Your score: {getScore()}
			</h1>
			<div class="fb-share-button"
				 data-href="http://localhost:5000/" 
				 data-layout="button" data-size="small">
				 <a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=http%3A%2F%2Flocalhost%3A5000%2F&amp;src=sdkpreparse"
				 class="fb-xfbml-parse-ignore">Share with friends!</a>
			</div>
		</div>
	{/if}
	
</div>