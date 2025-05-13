import nodemailer from 'nodemailer'

export const transporter = nodemailer.createTransport({
    service: "gmail",
    auth: {
        user: "aksheshpatel2019@gmail.com",
        pass: "byjc qblt enqo ysii"
    }
})