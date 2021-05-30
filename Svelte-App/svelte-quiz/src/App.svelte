<script>
	let questions = [
		{
			"question": "Кога е построена къщата музей на Иван Вазов в София?",
			"options": [
				"1800г.",
				"1895г.",
				"1880г."
			],
			"correctIndex": 1
		},
		{
			"question": "В коя стая е разположена личната библиотека на писателя?",
			"options": [
				"Гостната стая",
				"Личния кабинет",
				"Хола"
			],
			"correctIndex": 1
		},
		{
			"question": "През коя година е роден Иван Вазов?",
			"options": [
				"1850",
				"1921",
				"1860",
				"1800"
			],
			"correctIndex": 0
		}
	];
	let answers = new Array(questions.length).fill(null);
	let questionPointer = -1;

	function getScore(){
		let score = answers.reduce((acc,val,index)=>{
			if(questions[index].correctIndex == val){
				return acc+1;
			}
			return acc;
		},0);
		return (score/questions.length * 100).toFixed(0)+"%";
	}
</script>

<style>
	.main{
		height: 10em;
		display: flex;
		align-items: center;
		justify-content: center;
		margin-top:10%;
	}
	.main .start-button button,
	.main .question-component .options button{
		padding: 1rem;
		background-color: rgb(38, 112, 173);
		font-size: large;
		color:white;
		border-radius: 0.5rem;
		height: 70px;
		width: 140px;

	}
	.main .question-component .options button.selected{
		background-color: rgb(15, 60, 97);
	}

	.main .question-component,
	.main .score-component{
		padding: 5%;
		height: 15rem;
		width: 40rem;
		border-radius: 2%;
		box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
		text-align: center;
	}
	.main .question-component .options{
		margin: 5%;
		display: flex;
		justify-content: center;
	}
	.main .score-component .fb-share-button{
		margin: 7%
	}

</style>

<div class="main">
	{#if questionPointer==-1}
		<div class="start-button">
			<button on:click={()=>{questionPointer=0}}>
				Start Quiz
			</button>	
		</div>
	{:else if !(questionPointer > answers.length-1)}
		<div class="question-component">
			<div class="title">
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
		<div class="score-component">
			<h1>
				Your score: {getScore()}
			</h1>
			<div class="fb-share-button"
				 data-href="https://heuristic-lewin-72e643.netlify.app/" 
				 data-layout="button" data-size="large">
				 <a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=http%3A%2F%2Flocalhost%3A5000%2F&amp;src=sdkpreparse"
				 class="fb-xfbml-parse-ignore">Share with friends!</a>
			</div>
		</div>
	{/if}
	
</div>