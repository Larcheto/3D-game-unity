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
		<div class="score-screen">
			<h1>
				Your score: {getScore()}
			</h1>
		</div>
	{/if}
	
</div>