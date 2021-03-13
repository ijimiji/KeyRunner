<script>
	import Users from "./Users.svelte"
	import Login from "./Login.svelte"
	export let menu = 1;
</script>


<ul id="menu">
	<li><a href="/" on:click|preventDefault={() => (menu = 1)}>Users</a></li> 
	<li><a href="/" on:click|preventDefault={() => (menu = 2)}>Login</a></li>
</ul>

{#if menu === 1}
<Users />
{:else if menu === 2}
<Login />
{:else}
<h1>
	Page Not Found
</h1>
{/if}