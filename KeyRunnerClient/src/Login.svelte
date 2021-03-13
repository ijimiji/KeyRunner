<script>
    let _id = '1'
	let _name = 'Biba'
    let _username = 'Jasos'
	let result = null

    async function doPost () {
		const res = await fetch('https://localhost:5001/User', {
			method: 'POST',
			body: JSON.stringify({
				id: 1,
				name: "HEllo",
                username: "Hello"
			})
		})
        const json = await res.json()
		result = JSON.stringify(json)
    }
</script>

<input bind:value={_id} />
<input bind:value={_name} />
<input bind:value={_username} />
<button type="button" on:click={doPost}>
	Post it.
</button>
<p>
	Result:
</p>
<pre>
{result}
</pre>