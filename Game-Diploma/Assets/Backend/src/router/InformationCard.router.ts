import { Router } from 'express'
import {
    getAllInformationCards,
    getInformationCardById
} from '../controller/InformationCard.controller'

export const router = Router()

router.get('/', getAllInformationCards)
router.get('/:id', getInformationCardById)
