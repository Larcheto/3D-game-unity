import cors from 'cors'
import express, { Express } from 'express'
import { createConnection } from 'typeorm'
import { router } from './router/InformationCard.router'

const app: Express = express()

app.use(cors())
app.use(express.json())

app.use('/information-cards', router)

createConnection().then(() => {
    app.listen(process.env.PORT ?? 3000)
})
