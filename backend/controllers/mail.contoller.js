import {transporter} from '../config/mail.config.js'

export const sendMail = async (req, res) => {
    try {
        const {name, email, subject, message} = req.body;
        console.log(email, subject, message, "email check")

    await transporter.sendMail({
            from: email,
            subject: subject,
            text: message
        });

        res.status(200).json({
            message: "Email sent Successfully!",
            success: true
        })
    } catch (error) {
        console.log(error)
        res.status(500).json({ 
            message: "Failed to send email",
            success: false 
        });
    }
}