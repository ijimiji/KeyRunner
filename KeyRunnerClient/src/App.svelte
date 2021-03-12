<script>
	import { onMount } from 'svelte'
	let data
	onMount(async () => {
		data = await fetch('https://localhost:5001/User/Get').then(x => x.json())
	})
</script>

<pre>
	<h1>Hello world</h1>
	<div>{JSON.stringify(data)}<div>
</pre>
