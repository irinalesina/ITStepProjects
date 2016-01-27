#include "Test.h"
#include <vector>
#include <fstream>
#include <string>
#include "Question.h"
#include <sstream>
#include "ParseCSVString.h"
#include "Profession.h"
#include "Trait.h"
#include <iostream>
#include <map>
#include "Answer.h"
#include <algorithm>




bool IsInt(std::string &str)
{
	for (size_t i = 0; i < str.length(); i++)
	{
		if (str[i] < '0' || str[i] > '9')
			return false;
	}
	return true;
}

// ????????????????????????????
std::vector<Question> Test::questions;


// ????????????????????????????

void Test::LoadQuestions()
{
    // check
    if (questions.size())
        return;

	std::string buffer, number;
	std::ifstream file;
	file.open("../Data/Questions.csv");
	if (!file.is_open())
		throw std::exception("Error: file(Question.csv) is not opened!\n");
	int counter = 0, question_num;

	while (!file.eof())
	{
		std::getline(file, buffer);
		std::vector<std::string> data = ParseCSVString(buffer);
        if (!data.size())
            break;
	
		number = data[0];
		std::stringstream ss(number);
		ss >> question_num;
		if (counter == question_num)
		{
			Question q(data[1]);
			questions.push_back(q);
			counter++;
		}
		else
		{
			file.close();
			throw std::exception("Error: file(Question.csv) content!\n");
		}
	}
	file.close();

}




void Test::LoadAnswers()
{
	std::string buffer, number;
	std::ifstream file;

	file.open("../Data/Answers.csv");
	if (!file.is_open())
		throw std::exception("Error: file(Question.csv) is not opened!\n");

	int question_num;
	while (!file.eof())
	{
		std::getline(file, buffer);
		std::vector<std::string> data = ParseCSVString(buffer);
		if (!data.size())
			break;

		number = data[0];
		std::stringstream ss(number);
		ss >> question_num;

		Answer answer(data[1]);
		for (auto it = data.begin() + 2; it != data.end(); it++)
		{
			// read trait number
			int trait_, score_;
			number = *it;
			std::stringstream ss1(number);
			ss1 >> trait_;

			//read score
			it++;

			number = *it;
			std::stringstream ss2(number);
			ss2 >> score_;
			answer.AddPoint(trait_, score_);
		}
		questions[question_num].answers.push_back(answer);
	}
	file.close();
}





void Test::AskQuestion()
{
    // ASK QUESTION

    std::cout << questions[current_question].question << std::endl;
    // output annswer options for this question
    int answer_num = 1;
    for (auto it = questions[current_question].answers.begin();
		it != questions[current_question].answers.end(); it++, answer_num++)
        std::cout << answer_num << " - " << it->answer << std::endl;
    // processing answer
	std::string ratee_response;
	
	std::vector<int> ratee_answers;
	std::cout << "Give your answer from comma!" << std::endl;
	
    do
    {
		int correct = 1;
		std::getline(std::cin, ratee_response);
		std::vector<std::string> str_ratee_answers = ParseCSVString(ratee_response, ',');

		for (auto &ra : str_ratee_answers)
		{
			int ratee_answer;
			if (IsInt(ra))
				ratee_answer = std::atoi(ra.c_str());
			else
			{
				std::cout << "You enter invalid number! Try again!" << std::endl;
				correct = 0;
				break;;
			}
			
			if (ratee_answer < 1 || ratee_answer > answer_num - 1)
			{
				std::cout << "You enter invalid number! Try again!" << std::endl;
				correct = 0;
				break;
			}
		}
		if (!correct)
			continue;
		for (auto &ra : str_ratee_answers)
			ratee_answers.push_back(std::atoi(ra.c_str()));
		break;
    } while(true);


    // PROCESSING RESULT

	for (auto &ra : ratee_answers)
	{
		auto points = ((questions[current_question]).answers)[ra - 1].points;

		for (auto it = points.begin(); it != points.end(); it++)
			human.result[it->first] += it->second;
		
	}
    current_question++;
	system("cls");
}


void Test::ShowResult()
{
    int prof_number = 0;
    for (auto &pr: Profession::professions)
    {
        // ????????????????????????????????????????
        human.final_result[prof_number] = 0;
        for (auto &tr: pr.traits)
            human.final_result[prof_number] += human.result[tr];
		prof_number++;
    }

	struct ProfValue
	{
		trait_numb id_prof;
		int score;
		ProfValue(trait_numb id, int score_) : id_prof(id), score(score_) {}
	};

	std::vector<ProfValue> prof_value;

	for (auto &fr : human.final_result)
		prof_value.push_back(std::move(ProfValue(fr.first, fr.second)));

	
	std::sort(prof_value.begin() , prof_value.end(), 
		// lambda
		[](const ProfValue &i, const ProfValue &j) { return (i.score > j.score); }
	);
	std::cout << "Your professions:\n";
	for (auto pv : prof_value)
		std::cout << Profession::professions[pv.id_prof].name <<
		" - " << pv.score << std::endl;



	//for (auto pv : prof_value)


   // for (auto it = human.final_result.begin(); it != human.final_result.end(); it++)
   // {
   //     if (it->second == max_prof_point)
   //     {
   //         profession_number = it->first;
			//std::cout << it->first<< std::endl;
   //         std::cout << Profession::professions[profession_number].name << std::endl;
   //     }
   // }

}



