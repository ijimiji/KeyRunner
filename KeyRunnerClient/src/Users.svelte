<script>
	import { onMount } from 'svelte'
  import User from './User.svelte'
	let users
  
	onMount(async () => {
		await fetch('https://localhost:5001/User/GetAll')
            .then(x => x.json())
            .then(data => { users = data});
	})
</script>

<h1>Users</h1>
<div>{JSON.stringify(users)}</div>
{#if users}
  {#each users as user }
      <User {user} />
  {/each}
{:else}
  <p class="loading">loading...</p>
{/if}