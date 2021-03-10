import { Request, Response } from 'express'
import { InformationCard } from '../entity/InformationCard.entity'
import { InformationCardArrayResponse } from '../models/InformationCardArrayResponse'
import { getRepository } from 'typeorm'
import { Error } from '../models/Error'

export const getAllInformationCards = async (
    _: Request,
    response: Response<InformationCardArrayResponse | Error>
) => {
    const informationCards: InformationCard[] = await getRepository(InformationCard).find()

    if (!informationCards.length) {
        response.status(404).json({ status: 404, message: 'No Information Cards Found' })
        return
    }

    response.status(200).json({ informationCards })
}

export const getInformationCardById = async (
    request: Request<{ id: string }>,
    response: Response
) => {
    const {
        params: { id }
    } = request

    if (!Number(request.params.id)) {
        response.status(400).json({ status: 400, message: 'ID must be number or a numeric string' })
        return
    }

    const informationCard: InformationCard | undefined = await getRepository(
        InformationCard
    ).findOne(id)

    if (!informationCard) {
        response.status(404).json({ status: 404, message: 'Information Card Not Found' })
        return
    }

    response.status(200).json(informationCard)
}
