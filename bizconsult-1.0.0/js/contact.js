document.getElementById("contact-form").addEventListener("submit", async function (e) {
    e.preventDefault();

    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const subject = document.getElementById('subject').value;
    const message = document.getElementById('message').value;

    try {
        const res = await fetch("http://localhost:5000/api/send-email", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({name, email, subject, message})
        })

        const result = await res.json();
        alert(result.message);

        if (res.ok) {
            document.getElementById("contact-form").reset();
        }
        
    } catch (error) {
        alert("Something went wrong.")
    }
})