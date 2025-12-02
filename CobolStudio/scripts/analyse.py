import json
from os import error


def analyse(file_name):
    """Build models and perform analysis for COBOL file."""
    build_models(file_name)
    paragraphs = procedure_model.get_paragraphs()
    paragraph = paragraphs[0]
    sentences = paragraph.get_sentences()
    return sentences