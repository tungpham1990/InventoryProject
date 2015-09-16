package springweb.controllers;

import java.util.HashMap;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.support.SessionStatus;
import org.springframework.web.servlet.ModelAndView;
import springweb.entities.UserInfo;
import springweb.services.UserInfoService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/authorization")
public class UserController {

    @Autowired
    private UserInfoService userInfoService;

    @RequestMapping(value="/user", method=RequestMethod.GET , produces={"application/json"})
    public @ResponseBody Map<String, String> authorization(/*@RequestParam String UserName, @RequestParam String Password*/) throws Exception
    {
    	String UserName = "admin";
    	String Password = "admin";
    	Map<String, String> response = new HashMap<String, String>();
    	String status;
    	if(UserName == null || UserName == ""){
    		status = "FAIL";
    		response.put("Status", status);
    		return response;
    	}
    	UserInfo user = userInfoService.findByUserName(UserName);
    	if(user == null){
    		status = "FAIL";
    		response.put("Status", status);
    		return response;
    	}
    	if(user.getUserInfoCode().equals(Password)){
			status = "OK";
			response.put("Status", status);
			response.put("UserID", user.getUserInfoId().toString());
			return response;
    	}
    	status = "FAIL";
		response.put("Status", status);
		return response;
    }

    @RequestMapping(value = "/jsontest", method = RequestMethod.GET, produces={"application/json"})
    public @ResponseBody UserInfo index(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
        return user;
    }
    
    
    @RequestMapping(value = "/admin", method = RequestMethod.GET)
    public ModelAndView json(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
        ModelAndView mv = new ModelAndView("admin/user/list");
        mv.addObject("user", user);
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.GET)
    public ModelAndView add(ModelMap model) {
        ModelAndView mv = new ModelAndView("admin/user/add");
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.POST)
    public void save(ModelMap model) {

    }
}
